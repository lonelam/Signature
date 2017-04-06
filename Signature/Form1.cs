using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


using Org.BouncyCastle.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Crypto.Generators;



namespace Signature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private System.Security.Cryptography.X509Certificates.X509Certificate2 cert;
        private X509Certificate bouncy = null;
       
        private X509Certificate CA = null;
        private X509Certificate Castle = null;
        private AsymmetricKeyParameter Castlekey = null;
        private void importbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opener = new OpenFileDialog();
            opener.InitialDirectory = Environment.CurrentDirectory;
            opener.Filter = "公钥证书|*.cer|私钥证书|*.pfx";
            opener.RestoreDirectory = true;
            opener.FilterIndex = 1;
            if (opener.ShowDialog() == DialogResult.OK)
            {
                var fname = opener.FileName;
                var cerin = File.OpenText(fname);
                var txtreader = cerin.ReadToEnd();
                if (Path.GetExtension(fname) == ".cer")
                {
                    certificate.Text = txtreader;
                    txtreader = txtreader.Replace("-----BEGIN CERTIFICATE-----", "");
                    txtreader = txtreader.Replace("-----END CERTIFICATE-----", "");
                    txtreader = txtreader.Replace("\r\n", "");

                    var certb = Convert.FromBase64String(txtreader);
                    var cholder = new X509CertificateParser();
                    bouncy = cholder.ReadCertificate(certb);
                    cert = new System.Security.Cryptography.X509Certificates.X509Certificate2(certb);

                    nametxt.Text = bouncy.IssuerDN.ToString();

                    pubtxt.Text = Convert.ToBase64String(cert.GetPublicKey());
                    //Subtxt.Text = cert.Subject;
                }
                else if (Path.GetExtension(fname) == ".pfx")
                {
                    var pfxin = File.ReadAllBytes(fname);
                    var store = new Org.BouncyCastle.Pkcs.Pkcs12Store();
                    var stream = new MemoryStream(pfxin);
                    store.Load(stream, pswtxt.Text.ToCharArray());
                    foreach(string al in store.Aliases)
                    {
                        Castlekey = store.GetKey(al).Key;
                        Castle = store.GetCertificate(al).Certificate;
                    }
                }

            }
        }


        private void Signbut_Click(object sender, EventArgs e)
        {
            if(Castle == null)
            {
                MessageBox.Show("先导入或生成私钥");
                return;

            }
            ISigner sig = SignerUtilities.GetSigner(Castle.SigAlgName);
            sig.Init(true, Castlekey);
            var bmsg = Encoding.UTF8.GetBytes(msgtxt.Text);
            sig.BlockUpdate(bmsg, 0, bmsg.Length);
            var sigb = sig.GenerateSignature();
            sigtxt.Text = Convert.ToBase64String(sigb);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string signatureAlgorithm = algtxt.Text;
            var rsaGenerator = new RsaKeyPairGenerator();
            var randomGenerator = new CryptoApiRandomGenerator();
            var secureRandom = new SecureRandom(randomGenerator);
            var keyParameters = new KeyGenerationParameters(secureRandom, 1024);
            rsaGenerator.Init(keyParameters);
            var keyPair = rsaGenerator.GenerateKeyPair();
            var attributes = new System.Collections.Hashtable();

            attributes[X509Name.E] = emailtxt.Text;//设置dn信息的邮箱地址
            attributes[X509Name.CN] = towhomtxt.Text;//设置证书的用户，也就是颁发给谁
            attributes[X509Name.O] = Issuertxt.Text;//设置证书的办法者
            attributes[X509Name.C] = "Zh";//证书的语言
            var ordering = new System.Collections.ArrayList();
            ordering.Add(X509Name.E);
            ordering.Add(X509Name.CN);
            ordering.Add(X509Name.O);
            ordering.Add(X509Name.C);
            var generater = new X509V3CertificateGenerator();
            //设置证书序列化号
            generater.SetSerialNumber(BigInteger.ProbablePrime(120, new Random()));
            //设置颁发者dn信息
            generater.SetIssuerDN(new X509Name(ordering, attributes));
            //设置证书生效时间
            generater.SetNotBefore(DateTime.Today.Subtract(new TimeSpan(1, 0, 0, 0)));
            //设置证书失效时间
            generater.SetNotAfter(DateTime.Today.AddDays(365));
            //设置接受者dn信息
            generater.SetSubjectDN(new X509Name(ordering, attributes));
            //设置证书的公钥
            generater.SetPublicKey(keyPair.Public);
            //设置证书的加密算法
            generater.SetSignatureAlgorithm(signatureAlgorithm);
            generater.AddExtension(X509Extensions.BasicConstraints,
                true,
                new BasicConstraints(false));
            generater.AddExtension(X509Extensions.AuthorityKeyIdentifier,
                true,
                new AuthorityKeyIdentifier(SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(keyPair.Public)));
            // Key usage: Client authentication
            generater.AddExtension(X509Extensions.ExtendedKeyUsage.Id,
                false,
                new ExtendedKeyUsage(new System.Collections.ArrayList() { new DerObjectIdentifier("1.3.6.1.5.5.7.3.2") }));
            
            Castle = generater.Generate(keyPair.Private);
            var store = new Org.BouncyCastle.Pkcs.Pkcs12Store();
            string friendlyname = Castle.SubjectDN.ToString();
            var ccentry = new Org.BouncyCastle.Pkcs.X509CertificateEntry(Castle);
            store.SetCertificateEntry(friendlyname, ccentry);
            store.SetKeyEntry(friendlyname, new Org.BouncyCastle.Pkcs.AsymmetricKeyEntry(keyPair.Private), new[] { ccentry });

            certificate.Text = "-----BEGIN CERTIFICATE-----\r\n" + Convert.ToBase64String(Castle.GetEncoded()) + "\r\n-----END CERTIFICATE-----";
            
            string password = pswtxt.Text;
            Castlekey = keyPair.Private;
            var stream = new MemoryStream();
            store.Save(stream, password.ToCharArray(),secureRandom);
            nametxt.Text = Castle.IssuerDN.ToString();
            TextWriter textWriter = new StringWriter();
            PemWriter pemWriter = new PemWriter(textWriter);
            pemWriter.WriteObject(Castle.GetPublicKey());
            pemWriter.Writer.Flush();
            pubtxt.Text = textWriter.ToString();
            SaveFileDialog output = new SaveFileDialog();
            output.Filter = "pfx file|*.pfx";
            output.RestoreDirectory = true;
            output.InitialDirectory = Environment.CurrentDirectory;
            output.FilterIndex = 1;
            if (output.ShowDialog()==DialogResult.OK)
            File.WriteAllBytes(output.FileName, stream.ToArray());
            else
            {
                MessageBox.Show("pfx证书不导出！");
            }
            output.Filter = "cer file|*.cer";
            if (output.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(output.FileName, certificate.Text);
            }
            else
            {
                MessageBox.Show("cer证书没导出！");
            }
            
        }

        private void btn_import_CA_Click(object sender, EventArgs e)
        {
            OpenFileDialog opener = new OpenFileDialog();
            opener.InitialDirectory = Environment.CurrentDirectory;
            opener.Filter = "证书|*.cer";
            opener.RestoreDirectory = true;
            opener.FilterIndex = 1;
            if (opener.ShowDialog() == DialogResult.OK)
            {
                var fname = opener.FileName;

                var cerin = File.OpenText(fname);

                var txtreader = cerin.ReadToEnd();
                certificate.Text = txtreader;
                txtreader = txtreader.Replace("-----BEGIN CERTIFICATE-----", "");
                txtreader = txtreader.Replace("-----END CERTIFICATE-----", "");
                txtreader = txtreader.Replace("\r\n", "");
               
                var certb = Convert.FromBase64String(txtreader);
                CA = new X509CertificateParser().ReadCertificate(certb);
                //CA.GetBasicConstraints();
                if (bouncy != null)
                {
                    bool ok = true;
                    try
                    {
                        bouncy.Verify(CA.GetPublicKey());
                    }
                    catch (Exception se)
                    {
                        ok = false;
                        MessageBox.Show("验证数字证书失败");
                    }
                    if (ok) MessageBox.Show("你的数字证书被CA认证！");
                    //bouncy.GetSignature();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bouncy == null)
            {
                MessageBox.Show("先导入或生成公钥");
                return;
            }
            ISigner sig = SignerUtilities.GetSigner(bouncy.SigAlgName);
            sig.Init(false, bouncy.GetPublicKey());
            var bmsg = Encoding.UTF8.GetBytes(msgtxt.Text);
            sig.BlockUpdate(bmsg, 0, bmsg.Length);
            byte[] tar = null;
            try
            {
                tar =
                Convert.FromBase64String(sigtxt.Text);
            }
            catch(Exception exx)
            {
                MessageBox.Show("签名必须是base64");
            }
            if (sig.VerifySignature(tar))
            {
                MessageBox.Show("验签正确");
                
            }
            else
            {
                MessageBox.Show("验签失败");
            }
        }
    }
}

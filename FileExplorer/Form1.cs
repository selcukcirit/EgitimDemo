using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KlasorleriYukle();
        }

        public void KlasorleriYukle()
        {
            DirectoryInfo info = new DirectoryInfo(@"../../");

            if (info.Exists)
            {
                TreeNode rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;

                KlasorleriGetir(info.GetDirectories(), rootNode);

                treeView1.Nodes.Add(rootNode);
            }
        }

        private void KlasorleriGetir(DirectoryInfo[] altKlasorler, TreeNode eklenecekNode)
        {
            foreach (var altKlasor in altKlasorler)
            {
                TreeNode altKlasorunDugumu = new TreeNode(altKlasor.Name, 0, 0);
                altKlasorunDugumu.Tag = altKlasor;

                DirectoryInfo[] dahaAltKlasorler = altKlasor.GetDirectories();

                if (dahaAltKlasorler.Length > -1)
                {
                    KlasorleriGetir(dahaAltKlasorler, altKlasorunDugumu);
                }

                eklenecekNode.Nodes.Add(altKlasorunDugumu);
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode yeniSecilen = e.Node;

            DirectoryInfo yeniSecilenDirInfo = (DirectoryInfo)yeniSecilen.Tag;

            listView1.Items.Clear();

            //klasörleri listeler
            foreach (var dir in yeniSecilenDirInfo.GetDirectories())
            {
                ListViewItem item = new ListViewItem(dir.Name, 0);
                ListViewItem.ListViewSubItem[] altItemlar = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem(item, "Klasör"),
                    new ListViewItem.ListViewSubItem(item, dir.LastWriteTime.ToShortDateString())
                };

                item.SubItems.AddRange(altItemlar);
                listView1.Items.Add(item);
            }

            //dosyaları listeler
            foreach (var dir in yeniSecilenDirInfo.GetFiles())
            {
                ListViewItem item = new ListViewItem(dir.Name, 1);
                ListViewItem.ListViewSubItem[] altItemlar = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem(item, "Dosya"),
                    new ListViewItem.ListViewSubItem(item, dir.LastWriteTime.ToShortDateString())
                };

                item.SubItems.AddRange(altItemlar);
                listView1.Items.Add(item);
            }
        }
    }
}

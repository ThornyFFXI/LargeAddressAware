using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LargeAddressAwarePatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ui_Browse_Click(object sender, EventArgs e)
        {
            DialogResult Result = ui_Dialog.ShowDialog();
            if (Result == DialogResult.OK)
            {
                ui_FilePath.Text = ui_Dialog.FileName;
            }
        }

        private void ui_Patch_Click(object sender, EventArgs e)
        {
            try
            {
                using (var stream = File.Open(ui_FilePath.Text, FileMode.Open, FileAccess.ReadWrite))
                {
                    var reader = new BinaryReader(stream);
                    ushort mzHeader = reader.ReadUInt16();
                    if (mzHeader != 0x5A4D)
                    {
                        MessageBox.Show("No MZ header found.  Failed to patch.");
                        return;
                    }

                    reader.BaseStream.Position = 0x3C;
                    uint peOffset = reader.ReadUInt32();

                    reader.BaseStream.Position = peOffset;
                    if (reader.ReadUInt32() != 0x4550)
                    {
                        MessageBox.Show("No PE header found.  Failed to patch.");
                        return;
                    }

                    long flagAddress = reader.BaseStream.Position + 0x12;
                    reader.BaseStream.Position = flagAddress;

                    ushort flags = reader.ReadUInt16();
                    flags |= 0x20;

                    stream.Position = flagAddress;
                    stream.Write(BitConverter.GetBytes(flags), 0, 2);
                    reader.Close();
                    MessageBox.Show("Patch succeeded!");
                }
            }
            catch
            {
                MessageBox.Show("An error occured.  Failed to patch.");
            }
        }

        private void ui_Unpatch_Click(object sender, EventArgs e)
        {
            try
            {
                using (var stream = File.Open(ui_FilePath.Text, FileMode.Open, FileAccess.ReadWrite))
                {
                    var reader = new BinaryReader(stream);
                    ushort mzHeader = reader.ReadUInt16();
                    if (mzHeader != 0x5A4D)
                    {
                        MessageBox.Show("No MZ header found.  Failed to unpatch.");
                        return;
                    }

                    reader.BaseStream.Position = 0x3C;
                    uint peOffset = reader.ReadUInt32();

                    reader.BaseStream.Position = peOffset;
                    if (reader.ReadUInt32() != 0x4550)
                    {
                        MessageBox.Show("No PE header found.  Failed to unpatch.");
                        return;
                    }

                    long flagAddress = reader.BaseStream.Position + 0x12;
                    reader.BaseStream.Position = flagAddress;

                    ushort flags = reader.ReadUInt16();
                    if ((flags & 0x20) != 0)
                    {
                        flags -= 0x20;
                    }

                    stream.Position = flagAddress;
                    stream.Write(BitConverter.GetBytes(flags), 0, 2);
                    reader.Close();
                    MessageBox.Show("Unpatch succeeded!");
                }
            }
            catch
            {
                MessageBox.Show("An error occured.  Failed to unpatch.");
            }
        }
    }
}

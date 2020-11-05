using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private string gender;
        private void MaleRbt_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Nam";
        }

        private void FemaleRbt_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Nữ";
        }

        private string watch_film, listen_music, play;

        private void WatchFilmCb_CheckedChanged(object sender, EventArgs e)
        {
            if (WatchFilmCb.Checked == true)
                watch_film = WatchFilmCb.Text + ", ";
            else
                watch_film = "";
        }

        private void ListenMusicCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ListenMusicCb.Checked == true)
                listen_music = ListenMusicCb.Text + ", ";
            else
                listen_music = "";
        }

        private void PlayCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PlayCb.Checked == true)
                play = PlayCb.Text;
            else
                play = "";
        }

        private string sport, read;

        private void SportList_SelectedIndexChanged(object sender, EventArgs e)
        {
            sport = "";
            foreach (string s in this.SportList.SelectedItems)
                sport += s + " - ";
        }

        private void ReadList_SelectedIndexChanged(object sender, EventArgs e)
        {
            read = "";
            foreach (string r in this.ReadList.CheckedItems)
                read += r + " - ";
        }

        private void DoBdt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TakeInforBtn_Click(object sender, EventArgs e)
        {
            InforRtxtB.Text = "Họ tên: " + NameTxt.Text;
            InforRtxtB.Text += "\nQuê quán: " + CountryCbb.SelectedItem;
            InforRtxtB.Text += "\nNgày sinh: " + DoBdt.Value;
            InforRtxtB.Text += "\nGiới tính: " + gender;
            InforRtxtB.Text += "\nFree time: " + watch_film + listen_music + play;
            InforRtxtB.Text += "\nThể thao: " + sport;
            InforRtxtB.Text += "\nĐọc: " + read;
        }

        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

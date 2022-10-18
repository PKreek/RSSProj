using BusinessLayer.Controllers;
using Models;

namespace PodcastPlayer
{
    public partial class Form1 : Form
    {
        PodcastController podcastController;
        public Form1()
        {
            InitializeComponent();
            podcastController = new PodcastController();
        }

        private void btnNewPod_Click(object sender, EventArgs e)
        {
            Podcast podcast = podcastController.AddPodcast(txtUrl.Text);
            ListViewItem item = new ListViewItem(podcast.Episodes.Count.ToString());
            item.SubItems.Add(podcast.PodName);
            lstPodcasts.Items.Add(item);
            //foreach (var item in podcast.Episodes) 
            //{
            //    lstEpisode.Items.Add(item.EpisodeName);
            //}
           
        }


    }
}
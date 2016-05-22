using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sitting_Disease_Project
{
    /// <summary>
    /// Interaction logic for ActivityPopup.xaml
    /// </summary>
    public partial class ActivityPopup : Window
    {
        public ActivityPopup()
        {
            InitializeComponent();

            activityText.Text = "It's been 30 minutes since your last activity. Time to take a walk!";

            stretchText.Text = "Try this thoracic extension stretch:";

            stretchVideo.Source = new Uri(@"http://r9---sn-p5qlsnss.googlevideo.com/videoplayback?key=yt6&lmt=1345169871971691&dur=38.127&ratebypass=yes&source=youtube&nh=IgpwcjAzLmlhZDA3KgkxMjcuMC4wLjE&expire=1463880901&pl=40&mime=video%2Fmp4&sparams=dur%2Cid%2Cinitcwndbps%2Cip%2Cipbits%2Citag%2Clmt%2Cmime%2Cmm%2Cmn%2Cms%2Cmv%2Cnh%2Cpl%2Cratebypass%2Csource%2Cupn%2Cexpire&upn=zZG0VgXWqEc&ms=au&itag=18&initcwndbps=298750&ipbits=0&mv=m&mt=1463859048&mn=sn-p5qlsnss&mm=31&sver=3&id=o-AGMoTrClBUxhiU93uTJOVfkAYv3VrGyrJbCOiI5KIByA&fexp=9407610%2C9408210%2C9416126%2C9416891%2C9419451%2C9422342%2C9422596%2C9428398%2C9429585%2C9431012%2C9432363%2C9433045%2C9433096%2C9433425%2C9433858%2C9433946%2C9433999%2C9435058%2C9435466%2C9435876%2C9436085%2C9436118%2C9436213%2C9436606%2C9436846&signature=02F8F5B38F4B7A076BDBF8C59B90CEAD2147B253.8BDCA74BAA517978BE25DA318C03048E3B928297&ip=2a03%3A8180%3A1001%3A16a%3A%3A8ee1&title=Pivotal+Motion+Presents%3A+The+Thoracic+Extension+Stretch", UriKind.Absolute);
        }
    }
}

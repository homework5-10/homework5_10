using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GetNetData
{


    public class StockDaTa
    {
        string testUrl = "http://xueqiu.com/stock/screener/screen.json?category=SH&exchange=&areacode=&indcode=&orderby=symbol&order=desc&current=ALL&pct=ALL&page=1&pb=0_8085.71&roediluted.20150331=-8995.84_38.37&pelyr=0_57091.7255&mc=0_22712.9033&fmc=0_20094.5292&eps.20150331=-0.55_3.82&netprofit.20150331=-82911.6_7445700&dy=0_9.65&bps.20150331=-3.8_50.6&pettm=0_23356.1131&_=1431149845000";
        string CommUrl= "http://xueqiu.com/stock/screener/screen.json?category=SH&exchange=&areacode=&indcode=&orderby=symbol&order=desc&current=ALL&pct=ALL";
        string Url = null;
         //mc 總市值,FMC總股本,PETTM市盈率TTM,PELYR 市盈率LYR,EPS每股收益,PB市淨率,CURRENT現價,PCT日升幅,ROEDILUTED淨資產狀益率,BETPRCFIT淨利潤,DY股息率,BPS每股淨資產
       // string Reg = "(\"symbol\":\"[A-z]+[0-9]+\")|(\"name\":\"[\u4e00-\u9fa5]+\")|(\"mc\":[0-9]+\\.[0-9]+)|(\"fmc\":[0-9]+\\.[0-9]+)|(\"pettm\":[0-9]+\\.[0-9]+)|(\"pelyr\":[0-9]+\\.[0-9]+)|(\"eps\":\\{\"[0-9]+\":[0-9]+\\.[0-9]+\\})|(\"bps\":\\{\"[0-9]+\":[0-9]+\\.[0-9]+\\})|(\"roediluted\":\\{\"[0-9]+\":[0-9]+\\.[0-9]+\\})|(\"netprofit\":\\{\"[0-9]+\":[0-9]+\\.[0-9]+\\})|(\"dy\":[0-9]+\\.[0-9]+)|(\"pb\":[0-9]+\\.[0-9]+)|(\"current\":[0-9]+\\.[0-9]+)|(\"pct\":[0-9]+\\.[0-9]+)";
        string Reg = "\"symbol\":\"(?<num>[A-z]+[0-9]+)\"|\"name\":\"(?<name>[\u4e00-\u9fa5]+)\"|\"mc\":(?<mc>[0-9]+\\.[0-9]+)|\"fmc\":(?<fmc>[0-9]+\\.[0-9]+)|\"pettm\":(?<pettm>[0-9]+\\.[0-9]+)|\"pelyr\":(?<pelyr>[0-9]+\\.[0-9]+)|\"eps\":\\{\"[0-9]+\":(?<eps>[-]{0,1}[0-9]+\\.[0-9]+)\\}|\"bps\":\\{\"[0-9]+\":(?<bps>[-]{0,1}[0-9]+\\.[0-9]+)\\}|\"roediluted\":\\{\"[0-9]+\":(?<roediluted>[-]{0,1}[0-9]+\\.[0-9]+)\\}|\"netprofit\":\\{\"[0-9]+\":(?<netprofit>[-]{0,1}[0-9]+\\.[0-9]+)\\}|\"dy\":(?<dy>[0-9]+\\.[0-9]+)|\"pb\":(?<pb>[0-9]+\\.[0-9]+)|\"current\":(?<current>[0-9]+\\.[0-9]+)|\"pct\":(?<pct>[0-9]+\\.[0-9]+)";
        string CountReg = "\"count\":(?<count>[0-9]+)";
        WebClient MyClient;
        int Count = 0;
        public string Get(string Url)
        {
            MyClient = new WebClient();
            MyClient.Credentials = CredentialCache.DefaultCredentials;
            string header = "xq_a_token=a5fe91bb6c40fa9f33ff9f7a8db323114900ddd0;";
            MyClient.Headers.Add("Cookie", header);
            try
            {
                byte[] DownData = MyClient.DownloadData(Url);
                string DataStr = Encoding.UTF8.GetString(DownData);
                return DataStr;
            }
            catch (Exception err)
            {
                return null;
            }
        }

        public string SetUrl()
        {
            return testUrl;
        }

        public string SetUrl(string[] Resp)
        {
            Url = CommUrl;
           int ROWS = Resp.Count();
           for (int row=0; row<ROWS; row++)
           {
               Url = Url + Resp[row];
           }
           return Url;

        }

        public string[] SpiltStr(string input)
        {
            string temp = input;
            Regex reg = new Regex(Reg);
            Regex CouReg = new Regex(CountReg);
            try
            {
                Match StrCount = CouReg.Match(temp);
                MatchCollection MCrelust = reg.Matches(input);
                Count = int.Parse( StrCount.Groups["count"].Value.ToString());
                Count = int.Parse(StrCount.ToString());
                int ROWS = 0, item = 14;
                ROWS = MCrelust.Count;
                
                string[] relust = new string[ROWS];
                ROWS = ROWS / item;
                int row = 0;
                for (int col = 0; col < ROWS; col++)
                {
                    relust[row + 0] = MCrelust[row].Groups["num"].Value.ToString();
                    relust[row + 1] = MCrelust[row].Groups["name"].Value.ToString();
                    relust[row + 2] = MCrelust[row].Groups["mc"].Value.ToString();
                    relust[row + 3] = MCrelust[row].Groups["fmc"].Value.ToString();
                    relust[row + 4] = MCrelust[row].Groups["pettm"].Value.ToString();
                    relust[row + 5] = MCrelust[row].Groups["pelyr"].Value.ToString();
                    relust[row + 6] = MCrelust[row].Groups["eps"].Value.ToString();
                    relust[row + 7] = MCrelust[row].Groups["bps"].Value.ToString();
                    relust[row + 8] = MCrelust[row].Groups["roediluted"].Value.ToString();
                    relust[row + 9] = MCrelust[row].Groups["netprofit"].Value.ToString();
                    relust[row + 10] = MCrelust[row].Groups["dy"].Value.ToString();
                    relust[row + 11] = MCrelust[row].Groups["pb"].Value.ToString();
                    relust[row + 12] = MCrelust[row].Groups["current"].Value.ToString();
                    relust[row + 13] = MCrelust[row].Groups["pct"].Value.ToString();
                    row += item;
                }
                return relust;
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                return null;
            }
        }

        public int GetCount()
        {
            return Count;
        }

    }
}

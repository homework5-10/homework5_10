﻿using System;
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
        //string BaseUrl = "http://xueqiu.com/stock/screener/screen.json?category=SH&exchange=&areacode=&indcode=&orderby=symbol&order=desc&current=ALL&pct=ALL";
      //  string testUrl = "http://xueqiu.com/stock/screener/screen.json?category=SH&exchange=&areacode=&indcode=&orderby=symbol&order=desc&current=ALL&pct=ALL&page=1&pb=0_8085.71&roediluted.20150331=-8995.84_38.37&pelyr=0_57091.7255&mc=0_22712.9033&fmc=0_20094.5292&eps.20150331=-0.55_3.82&netprofit.20150331=-82911.6_7445700&dy=0_9.65&bps.20150331=-3.8_50.6&pettm=0_23356.1131&_=1431149845000";
       
        string CommUrl = "http://xueqiu.com/stock/screener/screen.json?category=US&indcode=&orderby=symbol&order=desc&current=ALL&pct=ALL";
        string BaseUrl = "http://xueqiu.com/stock/screener/screen.json?category=US&indcode=&orderby=symbol&order=desc&current=ALL&pct=ALL";
        // string CommUrl= "http://xueqiu.com/stock/screener/screen.json?category=SH&exchange=&areacode=&indcode=&orderby=symbol&order=desc&current=ALL&pct=ALL";
        //mc":null,"fmc":6.7525,"pettm":null,"pelyr":null,"eps":null,"bps":null,"roediluted":null,"netprofit":null,"dy":null,"pb":null,"current":27.01,"pct":43.98
        //mc 總市值,FMC總股本,PETTM市盈率TTM,PELYR 市盈率LYR,EPS每股收益,PB市淨率,CURRENT現價,PCT日升幅,ROEDILUTED淨資產狀益率,BETPRCFIT淨利潤,DY股息率,BPS每股淨資產
       // string Reg = "(\"symbol\":\"[A-z]+[0-9]+\")|(\"name\":\"[\u4e00-\u9fa5]+\")|(\"mc\":[0-9]+\\.[0-9]+)|(\"fmc\":[0-9]+\\.[0-9]+)|(\"pettm\":[0-9]+\\.[0-9]+)|(\"pelyr\":[0-9]+\\.[0-9]+)|(\"eps\":\\{\"[0-9]+\":[0-9]+\\.[0-9]+\\})|(\"bps\":\\{\"[0-9]+\":[0-9]+\\.[0-9]+\\})|(\"roediluted\":\\{\"[0-9]+\":[0-9]+\\.[0-9]+\\})|(\"netprofit\":\\{\"[0-9]+\":[0-9]+\\.[0-9]+\\})|(\"dy\":[0-9]+\\.[0-9]+)|(\"pb\":[0-9]+\\.[0-9]+)|(\"current\":[0-9]+\\.[0-9]+)|(\"pct\":[0-9]+\\.[0-9]+)";
      //  string Reg = "\"symbol\":\"(?<num>[A-z]+[0-9]+)\"|\"name\":\"(?<name>[\u4e00-\u9fa5]+)\"|\"mc\":(?<mc>[0-9]+\\.[0-9]+)|\"fmc\":(?<fmc>[0-9]+\\.[0-9]+)|\"pettm\":(?<pettm>[0-9]+\\.[0-9]+)|\"pelyr\":(?<pelyr>[0-9]+\\.[0-9]+)|\"eps\":\\{\"[0-9]+\":(?<eps>[-]{0,1}[0-9]+\\.[0-9]+)\\}|\"bps\":\\{\"[0-9]+\":(?<bps>[-]{0,1}[0-9]+\\.[0-9]+)\\}|\"roediluted\":\\{\"[0-9]+\":(?<roediluted>[-]{0,1}[0-9]+\\.[0-9]+)\\}|\"netprofit\":\\{\"[0-9]+\":(?<netprofit>[-]{0,1}[0-9]+\\.[0-9]+)\\}|\"dy\":(?<dy>[0-9]+\\.[0-9]+)|\"pb\":(?<pb>[0-9]+\\.[0-9]+)|\"current\":(?<current>[0-9]+\\.[0-9]+)|\"pct\":(?<pct>[0-9]+\\.[0-9]+)";
       // string Reg = "\"name\":\"(?<name>[A-z]*[\u4e00-\u9fa5]*[ ]*[A-z]*[\u4e00-\u9fa5]*[A-z]*[\u4e00-\u9fa5]*[ ]*[A-z]*[\u4e00-\u9fa5]*)\"|\"mc\":(?<mc>[0-9]*\\.[0-9]*)|\"fmc\":(?<fmc>[0-9]*\\.[0-9]*)|\"pettm\":(?<pettm>[0-9]*\\.[0-9]*)|\"pelyr\":(?<pelyr>[0-9]*\\.[0-9]*)|\"eps\":(?<eps>[-]{0,1}[0-9]*\\.[0-9]*)|\"bps\":(?<bps>[-]{0,1}[0-9]*\\.[0-9]*)|\"roediluted\":(?<roediluted>[-]{0,1}[0-9]*\\.[0-9]*)|\"dy\":(?<dy>[0-9]*\\.[0-9]*)|\"pb\":(?<pb>[0-9]*\\.[0-9]*)|\"current\":(?<current>[0-9]*\\.[0-9]*)|\"pct\":(?<pct>[-]{0,1}[0-9]*\\.[0-9]*)";
        string Reg = "\"name\":\"(?<name>[^\"]*)\"|\"mc\":(?<mc>[null]*[-]{0,1}[0-9]*[.]*[0-9]*)|\"fmc\":(?<fmc>[null]*[-]{0,1}[0-9]*[.]*[0-9]*)|\"pettm\":(?<pettm>[null]*[-]{0,1}[0-9]*[.]*[0-9]*)|\"pelyr\":(?<pelyr>[null]*[-]{0,1}[0-9]*[.]*[0-9]*)|\"eps\":(?<eps>[null]*[-]{0,1}[0-9]*[.]*[0-9]*)|\"bps\":(?<bps>[null]*[-]{0,1}[0-9]*[.]*[0-9]*)|\"roediluted\":(?<roediluted>[null]*[-]{0,1}[0-9]*[.]*[0-9]*)|\"dy\":(?<dy>[null]*[0-9]*[.]*[0-9]*)|\"pb\":(?<pb>[null]*[0-9]*[.]*[0-9]*)|\"current\":(?<current>[null]*[0-9]*[.]*[0-9]*)|\"pct\":(?<pct>[null]*[-]{0,1}[0-9]*[.]*[0-9]*)";
    
       
        string CountReg = "\"count\":(?<count>[0-9]+)";
        WebClient MyClient = new WebClient();
        int Count = 0;
        string header = null;
        public void SetCookie()
        {         
            
            MyClient.Credentials = CredentialCache.DefaultCredentials;
            try
            {
                string srcString = MyClient.DownloadString("http://xueqiu.com/");
                header = MyClient.ResponseHeaders["Set-Cookie"];
            }
            catch(Exception err)
            {
                header = "xq_a_token=39d6304bf28af3d0e6424795e0d0b210c91568c6";
            }
        }

        public string Get(string Url)
        {
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

        public string SetUrl(string[] Resp)
        {
          //  Url = CommUrl;
           int ROWS = Resp.Count();
           for (int row=0; row<ROWS; row++)
           {
               CommUrl = CommUrl + Resp[row];
           }
           return CommUrl;

        }

        public string[] SpiltStr(string input)
        {
            Regex reg = new Regex(Reg);
            Regex CouReg = new Regex(CountReg);
            try
            {
                MatchCollection MCrelust = reg.Matches(input);
                Match StrCount = CouReg.Match(input);
                Count = int.Parse(StrCount.Groups["count"].Value.ToString());
                Count = int.Parse(Count.ToString());
                int ROWS = 0, item = 12;
                ROWS = MCrelust.Count;
                
                string[] relust = new string[ROWS];
                    ROWS = ROWS / item;
                int row = 0;
                for (int col = 0; col < ROWS; col++)
                {
                   
                    relust[row + 0] = MCrelust[row+0].Groups["name"].Value.ToString();
                    relust[row + 1] = MCrelust[row+1].Groups["mc"].Value.ToString();
                    relust[row + 2] = MCrelust[row+2].Groups["fmc"].Value.ToString();
                    relust[row + 3] = MCrelust[row+3].Groups["pettm"].Value.ToString();
                    relust[row + 4] = MCrelust[row+4].Groups["pelyr"].Value.ToString();
                    relust[row + 5] = MCrelust[row+5].Groups["eps"].Value.ToString();
                    relust[row + 6] = MCrelust[row+6].Groups["bps"].Value.ToString();
                    relust[row + 7] = MCrelust[row+7].Groups["roediluted"].Value.ToString();
                    relust[row + 8] = MCrelust[row+8].Groups["dy"].Value.ToString();
                    relust[row + 9] = MCrelust[row+9].Groups["pb"].Value.ToString();
                    relust[row + 10] = MCrelust[row+10].Groups["current"].Value.ToString();
                    relust[row + 11] = MCrelust[row+11].Groups["pct"].Value.ToString();
                    row += item;
                }
                return relust;
            }
            catch (Exception err)
            {
                return null;
            }
        }

        public int GetCount()
        {
            return Count;
        }
        public string GetUrl()
        {
            return CommUrl;
        }
        public bool ReSetUrl()
        {
            try
            {
                CommUrl = BaseUrl;
                Count = 0;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

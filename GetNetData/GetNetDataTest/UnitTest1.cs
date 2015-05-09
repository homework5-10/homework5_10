﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetNetData;
using System.Text.RegularExpressions;

namespace GetNetDataTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void SetRespTest()
        {
            StockDaTa ST = new StockDaTa();
            string expected = "http://xueqiu.com/stock/screener/screen.json?category=SH&exchange=&areacode=&indcode=&orderby=symbol&order=desc&current=ALL&pct=ALL&page=1&pb=0_8085.71&roediluted.20150331=-8995.84_38.37&pelyr=0_57091.7255&mc=0_22712.9033&fmc=0_20094.5292&eps.20150331=-0.55_3.82&netprofit.20150331=-82911.6_7445700&dy=0_9.65&bps.20150331=-3.8_50.6&pettm=0_23356.1131&_=1431149845000";
            string actual = null;
            actual = ST.SetUrl();
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void SetRespTest2()
        {
            StockDaTa ST = new StockDaTa();
            string expected = "http://xueqiu.com/stock/screener/screen.json?category=SH&exchange=&areacode=&indcode=&orderby=symbol&order=desc&current=ALL&pct=ALL&page=1&pb=0_8085.71&roediluted.20150331=-8995.84_38.37&pelyr=0_57091.7255&mc=0_22712.9033&fmc=0_20094.5292&eps.20150331=-0.55_3.82&netprofit.20150331=-82911.6_7445700&dy=0_9.65&bps.20150331=-3.8_50.6&pettm=0_23356.1131";
            string actual = null;
            string[] Resp =new string[12];
            Resp[0] = "&page=1";
            Resp[1] = "&pb=0_8085.71";
            Resp[2] = "&roediluted.20150331=-8995.84_38.37";
            Resp[3] = "&pelyr=0_57091.7255";
            Resp[4] = "&mc=0_22712.9033";
            Resp[5] = "&fmc=0_20094.5292";
            Resp[6] = "&eps.20150331=-0.55_3.82";
            Resp[7] = "&netprofit.20150331=-82911.6_7445700";
            Resp[8] = "&dy=0_9.65";
            Resp[9] = "&bps.20150331=-3.8_50.6";
            Resp[10] = "&pettm=0_23356.1131";
            actual = ST.SetUrl(Resp);
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void GetNetStockBaseDataTest()
        {
            StockDaTa ST = new StockDaTa();
            string Url = string.Empty;
            string expected = null;
            string actual = ST.Get(Url);
          //  Assert.AreEqual(expected,actual);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void SpiltNullStringTest()
        {
            StockDaTa ST = new StockDaTa();
            string[] expected = null;
            string[] actual = null;
            string input = null;
            actual = ST.SpiltStr(input);
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void SpiltStringTest()
        {
            StockDaTa ST = new StockDaTa();
            string[] expected = null;
            string[] actual = null;
            string input = "{\"count\":1780,\"list\":[{\"id\":\"54b7af69e4b03f468920743c\",\"symbol\":\"SZ300419\",\"name\":\"浩丰科技\",\"setype\":null,\"exchange\":\"SZ\",\"areacode\":null,\"indcode\":null,\"mc\":98.825,\"fmc\":24.7664,\"pettm\":249.4631,\"pelyr\":184.1482,\"eps\":{\"20150331\":0.24},\"bps\":{\"20150331\":12.61},\"roediluted\":{\"20150331\":1.92},\"netprofit\":{\"20150331\":993.3},\"dy\":0.08,\"pb\":19.06,\"current\":0.0,\"pct\":0.0,";
            actual = ST.SpiltStr(input);
            Assert.IsNotNull(actual);
        }

    }
}
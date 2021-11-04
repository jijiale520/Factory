using System;
using Factory.Properties;

namespace Factory
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //中式风格
            IProduce chineseStyle = new ChineseStyle();
            //中式沙发
            ISofaFactory sofaChinese = chineseStyle.ProduceSofa();
            sofaChinese.Transport(new Train());
            sofaChinese.Price();
            sofaChinese.Weight();

            //欧式风格
            IProduce europeanStyle = new EuropeanStyle();
            //欧式沙发
            ISofaFactory sofaEuropean = europeanStyle.ProduceSofa();
            sofaEuropean.Transport(new Airplane());
            sofaEuropean.Price();
            sofaEuropean.Weight();

            //日式风格
            IProduce japanStyle = new JapanStyle();
            //日式沙发
            ISofaFactory sofaJapan = japanStyle.ProduceSofa();
            sofaJapan.Transport(new Ship());
            sofaJapan.Price();
            sofaJapan.Weight();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSite.Models
{
    public static class NewsModel
    {
        static NewsModel()
        {
            News = CreateDummyNews();
        }
        public static List<NewsEntry> News { get; set; }

        private static List<NewsEntry> CreateDummyNews()
        {
            var news1 = new NewsEntry()
            {
                Title = "Резиновый WWW: Почему украинские магазины уходят в интернет",
                Content = "Предпринимателям становится сложнее работать в традиционном ритейле. И некоторые из них все чаще переносят свои магазины в онлайн. Ведь в интернете не нужно платить за аренду помещений, нанимать много сотрудников и думать, как заставить людей приехать из другого конца города в свой магазин. На запуск своего интернет-магазина на торговой онлайн-площадке (маркетплейсе) хватит и нескольких тысяч гривень. Владельцы украинских интернет - магазинов поделились предпринимательским опытом и рассказали о своих пробах, ошибках и достижениях во всемирной сети.",
                Origin = new Uri("http://biz.liga.net/onlayn-biznes/all/stati/3647195-rezinovyy-internet-pochemu-predprinimateli-ukhodyat-v-onlayn.htm")
            };
            var news2 = new NewsEntry()
            {
                Title = "Курсы валют НБУ на 12.04.2017",
                Content = "На 12 апреля НБУ установил официальные курсы валют на уровне: 2689, 3785 грн за $100; 2855,0442 грн за 100 евро; 4,7219 грн за 10 руб РФ. На 11 апреля Нацбанком Украины были установлены следующие официальные курсы валют: 2693,3241 грн за $100; 2848,9982 грн за 100 евро; 4,6931 грн за 10 руб РФ.",
                Origin = new Uri("http://finance.liga.net/banks/2017/4/12/news/52832.htm")
            };
            var news3 = new NewsEntry()
            {
                Title = "Как украинцы делают деньги на идеях",
                Content = "Креативная экономика – это довольно расплывчатое понятие. В разных странах мира в разные времена в нее включали разные рынки. Но объединяет их одна общая черта. Эти сферы деятельности базируются на использовании человеческих знаний и умений. Продукты креативной экономики - товары и услуги, появление которых невозможно без активного вовлечения их создателя.",
                Origin = new Uri("http://www.liga.net/projects/just_business/")
            };

            return new List<NewsEntry>() { news1, news2, news3 };
        }
    }
}

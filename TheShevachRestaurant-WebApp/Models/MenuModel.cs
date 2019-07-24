using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheShevachRestaurant_WebApp.Models
{
    
    public class MenuModel
    {
        public List<Meal> Menus;
        private int IndexId = 100;

        public MenuModel()
        {

            Menus = new List<Meal>();
            //Entress Dish
            Menus.Add(new Meal(IndexId++, "Buffalo wings", "כנפיים פריכות ברוטב צ'ילי מתוק.", 48,"Entress", "/Content/PIC/MealPic/Buffalo-Wings.jpg"));
            Menus.Add(new Meal(IndexId++, "פטריית פורטובלו", "פטריית פורטובלו ממולאת בבשר בקר עם רוטב פטריות שמפניון ויין אדום.", 55,"Entress", "/Content/PIC/MealPic/Meat-Mushrooms.jpg"));
            Menus.Add(new Meal(IndexId++, "קרפצ'יו סינטה בלאק אנגוס", "עם שמן זית, חומץ בלסאמי, עלי רוקט ובצל סגול.", 55,"Entress", "/Content/PIC/MealPic/CarpaccioBlackAngus.jpg"));
            Menus.Add(new Meal(IndexId++, "חציל הפתעות", "ממולא בבשר בקר עם צנוברים טחינה לבנה וסלסת עגבניות.", 55,"Entress", "/Content/PIC/MealPic/Eggplants-Meat.jpg"));
            Menus.Add(new Meal(IndexId++, "פטה כבד עוף בליווי מוזיקה וצילצולים", "ריבת הבית וצנימים.", 48,"Entress", "/Content/PIC/MealPic/Chicken-Liver-Pate.jpg"));
            Menus.Add(new Meal(IndexId++, "סלט ירוק", "תערובת עלי בייבי , מיקס חסה, פטרוזיליה בזיליקום ובצל ירוק.", 40,"Entress", "/Content/PIC/MealPic/Green-Salad.jpg"));
            Menus.Add(new Meal(IndexId++, "סלט ערבי קצוץ דק", "מוגש עם טחינה לבנה.", 40,"Entress", "/Content/PIC/MealPic/Arab-Salad.jpg"));
            Menus.Add(new Meal(IndexId++, "חציל על האש", "עם טחינה ירוקה שום קונפי וטרטר עגבניות.", 48,"Entress", "/Content/PIC/MealPic/Eggplants-Thina.jpg"));
            //Main Dish
            Menus.Add(new Meal(IndexId++, "בורקס בשר", "בורקס בשר איכותי מוגש בליווי תפוח אדמה ובטטה, סלט ירק ורוטב הבית.", 75, "Main", "/Content/PIC/MealPic/.jpg"));
            Menus.Add(new Meal(IndexId++, "אנטריקוט בלאק אנגוס 500 גרם", "על פלנצ'ה רותחת - ברוטב יין אדום עם דואט תפוח אדמה ובטטה.", 195, "Main", "/Content/PIC/MealPic/Grilled-Entrecote-Steak-500.jpg"));
            Menus.Add(new Meal(IndexId++, "אנטריקוט בלאק אנגוס 300 גרם", "על פלנצ'ה רותחת - ברוטב יין אדום עם דואט תפוח אדמה ובטטה.", 155, "Main", "/Content/PIC/MealPic/Grilled-Entrecote-Steak-300.jpg"));
            Menus.Add(new Meal(IndexId++, "צלעות טלה טריות מרמת הגולן", ".3 צלעות בשר טרי מרמת הגולן על מצע תפו''א,  בטטה, פטריות ושום", 180, "Main", "/Content/PIC/MealPic/Lamb-Chops.jpg"));
            Menus.Add(new Meal(IndexId++, "דואט צלעות טלה ושיפודי אנטריקוט", "בשר טרי מרמת הגולן על מצע תפו''א,  בטטה, פטריות ושום.", 175, "Main", "/Content/PIC/MealPic/Duet-Lamb-Entrecote.jpg"));
            Menus.Add(new Meal(IndexId++, "סינטה עגל מרמת הגולן", "לצד דואט תפו''א ובטטה ורוטב צ'ימצורי בצד.", 145, "Main", "/Content/PIC/MealPic/Sinta.jpg"));
            Menus.Add(new Meal(IndexId++, "המבורגר 100% בקר טרי", "280 גרם, מוגש בלחמניית שומשום משוחה ברוטב הבית מוגש בליווי צ'יפס.", 70, "Main", "/Content/PIC/MealPic/Burger.jpg"));
            Menus.Add(new Meal(IndexId++, "המבורגר ציידים", "280 גרם, עם סלופי ג'ו פטריות בצל מטוגן, מועטר בטבעות בצל וצ'יפס.", 70, "Main", "/Content/PIC/MealPic/Hunter-Burger.jpg"));
            //Desserts
            Menus.Add(new Meal(IndexId++, "פנטזיה של שוקולד", "טארט קקאו, עם קראנץ' פאייטה, פיצוץ קרמו שוקולד נוגט עשיר ונימוח.", 45, "Desserts", "/Content/PIC/MealPic/A-Fantasy-Of-Chocolate.jpg"));
            Menus.Add(new Meal(IndexId++, "סופלה שוקולד חם", "בליווי גלידת וניל.", 45, "Desserts", "/Content/PIC/MealPic/Chocolate-Soufflé.jpg"));
            Menus.Add(new Meal(IndexId++, "באונטי", "ביסקוויט, קרמבו שוקולד נוגט, קראנץ' שוקולד, קרם קוקוס עשיר וגנאש.", 45, "Desserts", "/Content/PIC/MealPic/Baunti.jpg"));
            //Drinks
            Menus.Add(new Meal(IndexId++, "שתייה קלה או מוגזת", "קוקה קולה , זירו , ספרייט , תפוזים , לימונדה , פיוז טיי ועוד...", 13, "Drinks", "/Content/PIC/MealPic/Soft-Drinks.jpg"));
            Menus.Add(new Meal(IndexId++, "בירה", "קרלסברג , הייניקן , טובורג , מכבי, גולדסטאר, סטלה, קורונה.", 23, "Drinks", "/Content/PIC/MealPic/Beers.jpg"));
            Menus.Add(new Meal(IndexId++, "שתייה חמה", "תה, קפה, אספרסו.", 10, "Drinks", "/Content/PIC/MealPic/Hot-Drinks.jpg"));
        }
    }

    public class Meal
    {
        
        public string MealName ;
        public string MealDescription;
        public int MealPrice;
        public string MealCategory;
        public int MealId;
        public string MealImg;
        public Meal(int pMealId,string pMealName, string pDescription, int pPrice, string pCategory , string pImg)
        {
            MealId = pMealId;
            MealName = pMealName;
            MealDescription = pDescription;
            MealPrice = pPrice;
            MealCategory = pCategory;
            MealImg = pImg;
        }
    }
}
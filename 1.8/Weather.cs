using System;
using HtmlAgilityPack;
using Newtonsoft.Json;

class WeatherApp
{
    static void Main()
    {
        string CityDefault = "None";
        
        
        string GetTemperature(string CityForCheck)
        {
            string StringToReturn = "";
            
            if (CityForCheck == "" || CityForCheck == " ")
            {
                CityForCheck = CityDefault;
            }
            string url = $"https://www.weather-forecast.com/locations/{CityForCheck}/forecasts/latest";
            
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(url);
            
            HtmlNode temperature_Node = doc.DocumentNode.SelectSingleNode("//span[@class='temp']"); //температура
            HtmlNode weather_Node = doc.DocumentNode.SelectSingleNode("//span[@class='b-metar-table__weather-text']"); //погода (солнечно)    часто не работает на самом сайте
            
            string temperature = temperature_Node.InnerText;
            string weather = weather_Node.InnerText;
            
            if (float.Parse(temperature) > 0) //добавляю к температуре знак + (типо не 3, а +3)
            {
                temperature = ("+" + temperature);
            }

            StringToReturn += ($"!-----! {CityForCheck} !-----!\n");
            StringToReturn += ($"Температура : {temperature}\u00b0\u2009C\n");
            StringToReturn += ($"Погода : {weather}");

            return StringToReturn;
        };
        
        
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        

        try
        {
            //из джесона читает, если такой есть ЭТО ГОРОД ПО УМОЛЧАНИЮ!!!
            string jsonText = File.ReadAllText("data.json");
            CityDefault = JsonConvert.DeserializeObject<string>(jsonText);
            
            Console.WriteLine(GetTemperature(CityDefault));
        }
        catch
        {
            //ниче
        }

        
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        
        while (true) //бесконечно спрашивает город для отображения погоды
        {
            Console.WriteLine("Введите названия города в формате - Moscow или нажмите Enter, чтобы изменить город по умолчанию (сейчас это " + CityDefault + ")");
            string answ = Console.ReadLine();

            if (answ == "")
            {
                Console.WriteLine("Пожалуйста, напишите название для города по умолчанию в формате - London");
                string NewDefault = Console.ReadLine();
                File.WriteAllText("data.json", JsonConvert.SerializeObject(NewDefault));
            }
            else
            {
                Console.WriteLine(GetTemperature(answ));
            }
        }
    }
}
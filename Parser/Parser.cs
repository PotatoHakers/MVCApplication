using HtmlAgilityPack;


HtmlWeb web = new HtmlWeb();
HtmlDocument document = web.Load("https://ru.wikipedia.org/wiki/Nissan_Skyline");

var title = document.DocumentNode.SelectNodes("//*[@id=\"firstHeading\"]").First().InnerText;
var descrition = document.DocumentNode.SelectNodes("//*[@id=\"mw-content-text\"]/div[1]/p[1]").First().InnerText;

Console.WriteLine(title);
Console.WriteLine();
Console.WriteLine(descrition);



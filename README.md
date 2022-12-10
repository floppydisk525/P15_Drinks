# P15_Drinks  

## The Csharp Academy  

Csharpacademy project located here:    https://www.thecsharpacademy.com/project/15  
  
The github repository:  https://github.com/cappuccinocodes/CSharpAcademy.Console.DrinksInfo  

### Reference info   
Youtube video to create here:   https://www.youtube.com/watch?v=fc7peZ-FHs4  
On the project page there are links to the [cockatil database](https://www.thecocktaildb.com/api.php) and [Microsoft docs Http requests](https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/console-webapiclient).  HOWEVER, one issue I ran into is that the project from Pablo used Newtonsoft.Json and RestSharp.  He provided a link to [stackoverflow](https://stackoverflow.com/questions/59651742/net-core-httpclient-vs-restsharp/64283098) regarding differences in the two as many programmers go into this not knowing the differences.  

#### Cocktail API  
Here's some responses to the api weblinks.  
https://www.thecocktaildb.com/api/json/v1/1/list.php?c=list  
```
{"drinks":[{"strCategory":"Ordinary Drink"},{"strCategory":"Cocktail"},{"strCategory":"Shake"},{"strCategory":"Other \/ Unknown"},{"strCategory":"Cocoa"},{"strCategory":"Shot"},{"strCategory":"Coffee \/ Tea"},{"strCategory":"Homemade Liqueur"},{"strCategory":"Punch \/ Party Drink"},{"strCategory":"Beer"},{"strCategory":"Soft Drink"}]}
```  
  
https://www.thecocktaildb.com/api/json/v1/1/filter.php?i=brandy  
```
{"drinks":[{"strDrink":"Amaretto Shake","strDrinkThumb":"https:\/\/www.thecocktaildb.com\/images\/media\/drink\/xk79al1493069655.jpg","idDrink":"15194"},{"strDrink":"Bermuda Highball","strDrinkThumb":"https:\/\/www.thecocktaildb.com\/images\/media\/drink\/qrvtww1441206528.jpg","idDrink":"11084"},{"strDrink":"Between The Sheets","strDrinkThumb":"https:\/\/www.thecocktaildb.com\/images\/media\/drink\/of1rj41504348346.jpg","idDrink":"17184"},{"strDrink":"Boston Sidecar","strDrinkThumb":"https:\/\/www.thecocktaildb.com\/images\/media\/drink\/qzs5d11504365962.jpg","idDrink":"11128"},{"strDrink":"Brandy Alexander","strDrinkThumb":"https:\/\/www.thecocktaildb.com\/images\/media\/drink\/mlyk1i1606772340.jpg","idDrink":"11016"},{"strDrink":"Brandy Flip","strDrinkThumb":"https:\/\/www.thecocktaildb.com\/images\/media\/drink\/6ty09d1504366461.jpg","idDrink":"11164"},{"strDrink":"Brandy Sour","strDrinkThumb":"https:\/\/www.thecocktaildb.com\/images\/media\/drink\/b1bxgq1582484872.jpg","idDrink":"11170"},{"strDrink":"City Slicker","strDrinkThumb":"https:\/\/www.thecocktaildb.com\/images\/media\/drink\/dazdlg1504366949.jpg","idDrink":"11251"},{"strDrink":"English Highball","strDrinkThumb":"https:\/\/www.thecocktaildb.com\/images\/media\/drink\/dhvr7d1504519752.jpg","idDrink":"11338"},{"strDrink":"Gentleman's Club","strDrinkThumb":"https:\/\/www.thecocktaildb.com\/images\/media\/drink\/k2r7wv1582481454.jpg","idDrink":"11396"},{"strDrink":"Horse's Neck","strDrinkThumb":"https:\/\/www.thecocktaildb.com\/images\/media\/drink\/006k4e1504370092.jpg","idDrink":"17202"},{"strDrink":"Kioki Coffee","strDrinkThumb":"https:\/\/www.thecocktaildb.com\/images\/media\/drink\/uppqty1441247374.jpg","idDrink":"16951"},{"strDrink":"Mississippi Planters Punch","strDrinkThumb":"https:\/\/www.thecocktaildb.com\/images\/media\/drink\/urpyqs1439907531.jpg","idDrink":"11786"},{"strDrink":"Port Wine Cocktail","strDrinkThumb":"https:\/\/www.thecocktaildb.com\/images\/media\/drink\/qruprq1441553976.jpg","idDrink":"11963"},{"strDrink":"Porto flip","strDrinkThumb":"https:\/\/www.thecocktaildb.com\/images\/media\/drink\/64x5j41504351518.jpg","idDrink":"17192"},{"strDrink":"Quaker's Cocktail","strDrinkThumb":"https:\/\/www.thecocktaildb.com\/images\/media\/drink\/yrqppx1478962314.jpg","idDrink":"11983"},{"strDrink":"Scooter","strDrinkThumb":"https:\/\/www.thecocktaildb.com\/images\/media\/drink\/twuptu1483388307.jpg","idDrink":"12130"},{"strDrink":"Scotch Cobbler","strDrinkThumb":"https:\/\/www.thecocktaildb.com\/images\/media\/drink\/1q7coh1504736227.jpg","idDrink":"12138"},{"strDrink":"Sidecar Cocktail","strDrinkThumb":"https:\/\/www.thecocktaildb.com\/images\/media\/drink\/ewjxui1504820428.jpg","idDrink":"12198"},{"strDrink":"Sol Y Sombra","strDrinkThumb":"https:\/\/www.thecocktaildb.com\/images\/media\/drink\/3gz2vw1503425983.jpg","idDrink":"12256"},{"strDrink":"Stinger","strDrinkThumb":"https:\/\/www.thecocktaildb.com\/images\/media\/drink\/2ahv791504352433.jpg","idDrink":"17193"},{"strDrink":"Victor","strDrinkThumb":"https:\/\/www.thecocktaildb.com\/images\/media\/drink\/voapgc1492976416.jpg","idDrink":"12450"}]}
```  

##  THE END
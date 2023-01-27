Обучающие задание от microsoft:
"Для продвижения новейших продуктов компании мы отправим тысячи персонализированных писем существующим клиентам нашей компании. 
Мы должны написать код на C#, который объединит персонализированные сведения о клиенте. В письме будет указана такая информация, 
как их существующий портфель, и текущие доходы будут сравниваться с прогнозируемыми, если они захотят использовать наши новые продукты.
Наши авторы выбрали следующий пример маркетингового сообщения. Вот желаемый результат (на основе вымышленных данных учетной записи клиента):
(представлен образец конечного вывода в консоль)

Ниже приведены правила для задачи.

1. Используйте редактор .NET для создания сообщения с учетом переменных и кода. Замените комментарии кода собственным кодом форматирования строки.
2. Вы не можете удалить существующий код, за исключением комментариев.

******************************************************************************************************************************************************

Начальный код и заданные переменные.
```
string customerName = "Mr. Jones";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here

Console.WriteLine(comparisonMessage);
```

Вывод по заданию:

```
Dear Mr. Jones,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75 %.

Our new product, Glorious Future offers a return of 13.13 %.  Given your current volume, your potential profit would be ¤63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75 %   ¤55,000,000.00      
Glorious Future     13.13 %   ¤63,000,000.00  
```
## Библиотека для работы с API МоноБанк
Для вызова методов API создайте соответствующий адаптер (```IMonoPersonal or IMonoPublic```) и вызовите нужный метод.
```
using (IMonoPersonal adapter = new MonoPersonal(token))
{  
  var data = adapter.ReturnStatement("1559385897", "1561977897", acc: "zCmoEgPv-xw4dNV20NqzaA").Result;    
}
  ```
Конструктивная критика приветствуется.

Если вдруг проявите дикое желание отблагодарить, вот вам номер карты:
💰 5375 4141 0039 1514

Для ленивых <code> <b>--></b> https://send.monobank.com.ua/NNG8cy25 "</code>
## Библиотека для работы с API МоноБанк
Докумментация https://api.monobank.ua/docs/index.html

Для использования установите пакет <code>[Install-Package Mono.Api.Connector -Version 2.0.0](https://www.nuget.org/packages/Mono.Api.Connector/)</code>

Для вызова методов API воспользуйтесь внедрением зависимостей в ваш контейнер.
```csharp
services.AddMonoApi("token"); 

...

public class ConectorService
{
    private readonly IMonoPersonal _conector;

    public ConectorService(IMonoPersonal conector)
    {
        _conector = conector;
    }
}

...

var result = await _connector.SetWebHookAsync("webhook-url");
```

Конструктивная критика приветствуется.


Если вдруг проявите дикое желание отблагодарить <code> <b>--></b> https://send.monobank.com.ua/NNG8cy25 "</code>

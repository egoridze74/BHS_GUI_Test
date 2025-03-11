# Задание №3 Вспомогательный метод
```
public static class HashSetExtensions
{
   public static IReadOnlyList<T> ConvertToList<T>(this HashSet<T> hashSet)
   {
       var result = new List<T>();

       foreach (var value in hashSet)
       {
           result.Add(value);
       }
      
       return result;
   }
}
```
В данной реализации метода не задаётся начальная ёмкость списка List, вследствие чего список будет многократно расширяться и перераспределять память, что может повлиять на производительность программы.

Изменнённая реализация с определённой ёмкостью списка:
```
public static class HashSetExtensions
{
   public static IReadOnlyList<T> ConvertToList<T>(this HashSet<T> hashSet)
   {
       var result = new List<T>(hashSet.Count);

       foreach (var value in hashSet)
       {
           result.Add(value);
       }
      
       return result;
   }
}

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using static System.Console;
// README.md를 읽고 코드를 작성하세요.

// 1-1
string name = null;
name ??= "이름 없어";
WriteLine(name);
name ??= "뉴 네임";
WriteLine(name);

WriteLine();

// 1-2
string playerName = null;
if (playerName == null)
{
    playerName = "Player";
}
WriteLine(playerName);

WriteLine();

// 1-3
// 리스트 변수 null 선언
List<string> _items = null;
_items ??= new List<string>();
_items.Add("검");

_items ??= new List<string>(); // 무시되어야 하지만 무시되지 않음? -> ??=를 빼먹음
_items.Add("방패");
WriteLine($"아이템 수: {_items.Count}");
WriteLine($"-{_items[0]}");
WriteLine($"-{_items[1]}");

WriteLine();

// 2-1 
string message = null;
int? num1 = message?.Length; 
WriteLine($"길이: {num1}");
message = "안녕하세요";
// int는 값형 데이터기 때문에 다시 할당을 해줘야 함
num1 = message.Length;
WriteLine($"길이: {num1}");

WriteLine();

// 2-2
// ?. (조건) 연산자 좌측 변수가 null이면 null 사용
// ?? (병합) 좌측 값이 null이면 오른쪽 값 사용
// ??= (병합 할당) 좌측 값이 null 이면 오른쪽 값 좌측에 할당
string text = null;
if (text?.Length == null)
{
    WriteLine("텍스트가 없습니다.");
}
else
{
    WriteLine($"텍스트 길이: {text?.Length}");
}

WriteLine();

// 2-3
string name1 = null;
WriteLine($"대문자: {name1?.ToUpper()}");
name1 = "hello";
WriteLine($"대문자: {name1?.ToUpper()}");

WriteLine();

// 2-4
string text1 = null;
WriteLine($"결과: {text1?.ToUpper()?.Trim()}");
text1 = "   hello   ";
WriteLine($"결과: {text1?.ToUpper()?.TrimEnd()}");

WriteLine();

// 2-5
List<string> items = null;
int? itemsNum = items?.Count;
WriteLine($"아이템 수: {itemsNum}");
items = new List<string> { "사과", "바나나" };
itemsNum = items.Count;
WriteLine($"아이템 수: {itemsNum}");

WriteLine();

// 3-1
string message1 = null;
//?? => 좌측 값이 null 이면 오른쪽 값을 사용함
int msgLeng = message1?.Length ?? 0;
WriteLine($"길이: {msgLeng}");
message1 = "Hello";
msgLeng = message?.Length ?? 0;
WriteLine($"길이: {msgLeng}");

WriteLine();

// 3-2
List<string> names = null;
WriteLine($"이름 수: {names?.Count() ?? 0}");
names = new List<string> { "Kim", "Lee", "Park" };
WriteLine($"이름 수: {names?.Count() ?? 0}");

WriteLine();

// 3-3
string playername = null;
int? playerLevel = null;
List<string> inventory = null;
WriteLine($"플레이어: {playername ?? "Unknown"}");
WriteLine($"레벨: {playerLevel ?? 1}");
WriteLine($"인벤토리 아이템: {inventory?.Count ?? 0}개");

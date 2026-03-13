using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using static System.Console;

// README.md를 읽고 코드를 작성하세요.


// 1
int number = 0;
string text = "";
string[] nothing = null;

WriteLine($"{number}");
WriteLine($"{text}");
WriteLine($"{nothing}");

WriteLine();

// 2
string name = null;
WriteLine(name == null);

WriteLine();

// 3-1
// 권장되는 기본적인 Nullable 형식 선언 방법
int? i = null;
double? d = null;
bool? b = null;
// Nullable<T> 형식 선언 방법
Nullable<int> ni = null;
Nullable<double> nd = null;

WriteLine(i);
WriteLine(d);
WriteLine(b);

WriteLine();

// 3-2
int? score = null;
WriteLine($"score.HasValue: {score.HasValue}");
score = 95;
WriteLine($"score.HasValue: {score.HasValue}");
WriteLine($"score.Value: {score.Value}");

WriteLine();


// 3-3
int? empty = null;

void ReturnAnswer(int? ing)
{
    if (ing.HasValue)
    {
        WriteLine(ing.Value);
    }
    else
    {
        WriteLine("값 ㄴㄴ");
    }
}
ReturnAnswer(empty);

WriteLine();

// 3-4
int? level = null;
int defaultLvl = level.GetValueOrDefault();
WriteLine($"기본값 사용: {defaultLvl}");
int customLvl = level.GetValueOrDefault(1);
WriteLine($"커스텀 기본값: {customLvl}");
level = 50;
WriteLine($"값이 있을때: {level}");

WriteLine();

// 3-5
int num = 42;
// num을 암시적 변환 할당
int? nullable = num;
WriteLine($"nullable: {nullable}");
int back = (int)num;
WriteLine($"back: {back}");

WriteLine();

// 4-1
// ?? 연산자는 Null을 다루는 연산자
//좌측 값이 null일 경우 우측 값을 반환하고, null이 아니라면 좌측값을 반환
string message = null;
// 현재 message값은 null이므로 우측 값을 반환
string result = message ?? "기본 메세지";
WriteLine(result);
message = "안녕하십니가";
// 값을 할당했으므로 (null이 아님) 좌측 값 반환
result = message ?? "기본 메세지";
WriteLine(result);  

WriteLine();

// 4-2
string input = null;
string output;
if (input == null) 
{
    output = "기본값";
}
else
{
    output = input;
}
WriteLine($"if문 결과: {output}");
output = input ?? "기본값";
WriteLine($"?? 연산자 결과: {output}");

WriteLine();

// 4-3

int? score1 = null;
int scoresult = score1 ?? -1; 
int? health = null;
int healresult = health ?? default(int);
WriteLine($"점수: {scoresult}");
WriteLine($"체력: {healresult}");

WriteLine();

// 4-4
string first = null;
string second = null;
string third = "세 번째 값";
string result2 = first ?? second ?? third;
WriteLine(result2);

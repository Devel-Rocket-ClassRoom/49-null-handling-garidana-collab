using System;
using static System.Console;
// README.md를 읽고 아래에 코드를 작성하세요.
int?[] scores = { 3, null, 7, null, 5 };
int N = 0;
int totalGames = 0;
int? totalScore = 0;
WriteLine("=== 경기 상태 ===");

foreach (int? score in scores)
{
    N++;
    if (score.HasValue)
    {
        WriteLine($"경기 {N}: {score}점 (진행 완료)");
        totalGames++;
        totalScore += score;
    }
    else
    {
        WriteLine($"경기 {N}: 미진행");
    }

}
N = 0;
WriteLine();
WriteLine("=== 전체 점수 (미진행 = -1) ===");
foreach (int? score in scores)
{
    N++;
    if (score.HasValue)
    {
        WriteLine($"경기 {N}: {score.GetValueOrDefault(-1)}");
        
    }
    else
    {
        WriteLine($"경기 {N}: {score.GetValueOrDefault(-1)}");
    }
}
N = 0;
WriteLine();
WriteLine("=== 통계 ===");
WriteLine($"진행된 경기 수: {totalGames}");
WriteLine($"총점: {totalScore}");
WriteLine($"평균: {totalScore / totalGames:N1}");
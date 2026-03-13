using System;
using System.Collections.Generic;
using static System.Console;

List<string>? player1Items = null; // 인벤토리 미생성;
List<string>? player2Items = new List<string>(); // 빈 리스트 할당;
List<string>? player3Items = new() { "검", "방패", "포션" };
// 플레이어 1
WriteLine("=== 플레이어 1 (인벤토리 없음) ===");
WriteLine($"아이템 수: {player1Items?.Count ?? 0}");
WriteLine($"첫 번째 아이템: {player1Items?[0] ?? "없음"}");
WriteLine($"마지막 아티템: {player1Items?[^1] ?? "없음"}");

WriteLine();
// 플레이어 2
WriteLine("=== 플레이어 2 (빈 인벤토리) ===");
WriteLine($"아이템 수: {player2Items?.Count ?? 0}");
// 그냥 ?[0]으로 접근하니 IndexOutOfRange NullReception 발생함
// 리스트가 비어있는 상태라서 예외 발생
// 따라서 이 경우 삼항연산자 사용
WriteLine($"첫 번째 아이템: {(player2Items == null || player2Items.Count == 0 ? "없음" : player2Items[0])}");
WriteLine($"마지막 아이템: {(player2Items == null || player2Items.Count == 0 ? "없음" : player2Items[^1])}");

WriteLine();
// 플레이어 3
WriteLine("=== 플레이어 3 (아이템 보유) ===");
WriteLine($"아이템 수: {player3Items?.Count ?? 0}");
WriteLine($"첫 번째 아이템: {player3Items?[0] ?? "없음"}");
WriteLine($"마지막 아이템: {player3Items?[^1] ?? "없음"}");

// 데이터형 뒤에 ? (null을 포함한다는 뜻)이 들어간 상황에서는 항상 ??=, ?. ,?을 넣어서
// 예외 처리를 해 줄것.

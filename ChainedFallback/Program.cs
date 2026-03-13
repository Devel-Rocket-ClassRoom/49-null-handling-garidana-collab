using System;
using static System.Console;

// 1. 먼저 설정 항목당 4단계의 소스를 선언

// 플레이어 이름 소스
string? userPlayerName = null;
string? profilePlayerName = "프로필 유저";
string? globalPlayerName = null;
string? defaultPlayerName = "Player";
// 서버 주소 소스
string? userServerAddress = null;
string? profileServerAddress = null;
string? globalServerAddress = null;
string? defaultServerAddress = "localhost";
// 언어 소스
string? userLang = "English";
string? profileLang = "Korean";
string? globalLang = "Japanese";
string? defaultLang = "Korean";
// 볼륨 소스
int? userVol = null;
int? profileVol = null;
int? globalVol = 70;
int? defaultVol = 50;

// 2. ?? 체이닝으로 사용할 최종 값을 결정
// 최종값을 담을 변수 선언 및 할당
string? finalName = userPlayerName ?? profilePlayerName ?? globalPlayerName ?? defaultPlayerName;
string? finalServer = userServerAddress ?? profileServerAddress ?? globalServerAddress ?? defaultServerAddress;
string? finalLang = userLang ?? profileLang ?? globalLang ?? defaultLang;
int? finalVol = userVol ?? profileVol ?? globalVol ?? defaultVol;

WriteLine("=== 설정 결정 ===");
WriteLine($"플레이어 이름: {finalName} (프로필 설정에서 가져옴)");
WriteLine($"서버 주소: {finalServer} (기본값에서 가져옴)");
WriteLine($"언어: {finalLang} (사용자 설정에서 가져옴)");
WriteLine($"볼륨: {finalVol} (전역 설정에서 가져옴)");
WriteLine();
string? cachePlayerName = null;
string? cacheServer = null;
string? cacheLang = null;
int? cacheVol = null;
WriteLine("=== 캐시 저장 (??=) ===");
WriteLine($"캐시 저장전: {cachePlayerName ?? "null"}");
cachePlayerName ??= profilePlayerName;
WriteLine($"첫 번째 ??= 적용 후: {cachePlayerName}");
cachePlayerName ??= finalName;
WriteLine($"두 번째 ??= 적용 후: {cachePlayerName}");
cacheServer ??= finalServer;
cacheLang ??= finalLang;
cacheVol ??= finalVol;
WriteLine();
WriteLine("=== 최종 설정 ===");
WriteLine($"플레이어 이름: {cachePlayerName}");
WriteLine($"서버 주소: {cacheServer}");
WriteLine($"언어: {cacheLang}");
WriteLine($"볼륨: {cacheVol}");

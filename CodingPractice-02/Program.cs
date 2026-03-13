using System;
using System.Collections.Generic;
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

List<string> _items = null;
_items ??= new List<string>();
_items.Add("검");

_items = new List<string>();
_items.Add("방패");
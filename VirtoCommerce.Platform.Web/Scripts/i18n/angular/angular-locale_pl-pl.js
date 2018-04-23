﻿"use strict"; angular.module("ngLocale", [], ["$provide", function (e) { function a(e) { e += ""; var a = e.indexOf("."); return a == -1 ? 0 : e.length - a - 1 } function i(e, i) { var n = i; void 0 === n && (n = Math.min(a(e), 3)); var r = Math.pow(10, n), t = (e * r | 0) % r; return { v: n, f: t } } var n = { ZERO: "zero", ONE: "one", TWO: "two", FEW: "few", MANY: "many", OTHER: "other" }; e.value("$locale", { DATETIME_FORMATS: { AMPMS: ["AM", "PM"], DAY: ["niedziela", "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota"], ERANAMES: ["p.n.e.", "n.e."], ERAS: ["p.n.e.", "n.e."], FIRSTDAYOFWEEK: 0, MONTH: ["stycznia", "lutego", "marca", "kwietnia", "maja", "czerwca", "lipca", "sierpnia", "września", "października", "listopada", "grudnia"], SHORTDAY: ["niedz.", "pon.", "wt.", "śr.", "czw.", "pt.", "sob."], SHORTMONTH: ["sty", "lut", "mar", "kwi", "maj", "cze", "lip", "sie", "wrz", "paź", "lis", "gru"], WEEKENDRANGE: [5, 6], fullDate: "EEEE, d MMMM y", longDate: "d MMMM y", medium: "dd.MM.y HH:mm:ss", mediumDate: "dd.MM.y", mediumTime: "HH:mm:ss", short: "dd.MM.y HH:mm", shortDate: "dd.MM.y", shortTime: "HH:mm" }, NUMBER_FORMATS: { CURRENCY_SYM: "zł", DECIMAL_SEP: ",", GROUP_SEP: " ", PATTERNS: [{ gSize: 3, lgSize: 3, maxFrac: 3, minFrac: 0, minInt: 1, negPre: "-", negSuf: "", posPre: "", posSuf: "" }, { gSize: 3, lgSize: 3, maxFrac: 2, minFrac: 2, minInt: 1, negPre: "-", negSuf: " ¤", posPre: "", posSuf: " ¤" }] }, id: "pl-pl", pluralCat: function (e, a) { var r = 0 | e, t = i(e, a); return 1 == r && 0 == t.v ? n.ONE : 0 == t.v && r % 10 >= 2 && r % 10 <= 4 && (r % 100 < 12 || r % 100 > 14) ? n.FEW : 0 == t.v && 1 != r && r % 10 >= 0 && r % 10 <= 1 || 0 == t.v && r % 10 >= 5 && r % 10 <= 9 || 0 == t.v && r % 100 >= 12 && r % 100 <= 14 ? n.MANY : n.OTHER } }) }]);

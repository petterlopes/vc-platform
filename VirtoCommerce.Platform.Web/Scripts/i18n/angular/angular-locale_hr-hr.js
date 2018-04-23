﻿"use strict"; angular.module("ngLocale", [], ["$provide", function (e) { function a(e) { e += ""; var a = e.indexOf("."); return a == -1 ? 0 : e.length - a - 1 } function r(e, r) { var n = r; void 0 === n && (n = Math.min(a(e), 3)); var t = Math.pow(10, n), i = (e * t | 0) % t; return { v: n, f: i } } var n = { ZERO: "zero", ONE: "one", TWO: "two", FEW: "few", MANY: "many", OTHER: "other" }; e.value("$locale", { DATETIME_FORMATS: { AMPMS: ["AM", "PM"], DAY: ["nedjelja", "ponedjeljak", "utorak", "srijeda", "četvrtak", "petak", "subota"], ERANAMES: ["Prije Krista", "Poslije Krista"], ERAS: ["pr. Kr.", "p. Kr."], FIRSTDAYOFWEEK: 0, MONTH: ["siječnja", "veljače", "ožujka", "travnja", "svibnja", "lipnja", "srpnja", "kolovoza", "rujna", "listopada", "studenoga", "prosinca"], SHORTDAY: ["ned", "pon", "uto", "sri", "čet", "pet", "sub"], SHORTMONTH: ["sij", "velj", "ožu", "tra", "svi", "lip", "srp", "kol", "ruj", "lis", "stu", "pro"], WEEKENDRANGE: [5, 6], fullDate: "EEEE, d. MMMM y.", longDate: "d. MMMM y.", medium: "d. MMM y. HH:mm:ss", mediumDate: "d. MMM y.", mediumTime: "HH:mm:ss", short: "dd.MM.y. HH:mm", shortDate: "dd.MM.y.", shortTime: "HH:mm" }, NUMBER_FORMATS: { CURRENCY_SYM: "kn", DECIMAL_SEP: ",", GROUP_SEP: ".", PATTERNS: [{ gSize: 3, lgSize: 3, maxFrac: 3, minFrac: 0, minInt: 1, negPre: "-", negSuf: "", posPre: "", posSuf: "" }, { gSize: 3, lgSize: 3, maxFrac: 2, minFrac: 2, minInt: 1, negPre: "-", negSuf: " ¤", posPre: "", posSuf: " ¤" }] }, id: "hr-hr", pluralCat: function (e, a) { var t = 0 | e, i = r(e, a); return 0 == i.v && t % 10 == 1 && t % 100 != 11 || i.f % 10 == 1 && i.f % 100 != 11 ? n.ONE : 0 == i.v && t % 10 >= 2 && t % 10 <= 4 && (t % 100 < 12 || t % 100 > 14) || i.f % 10 >= 2 && i.f % 10 <= 4 && (i.f % 100 < 12 || i.f % 100 > 14) ? n.FEW : n.OTHER } }) }]);

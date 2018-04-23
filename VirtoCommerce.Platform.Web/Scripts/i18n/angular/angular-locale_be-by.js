﻿"use strict"; angular.module("ngLocale", [], ["$provide", function (e) { var E = { ZERO: "zero", ONE: "one", TWO: "two", FEW: "few", MANY: "many", OTHER: "other" }; e.value("$locale", { DATETIME_FORMATS: { AMPMS: ["да палудня", "пасля палудня"], DAY: ["нядзеля", "панядзелак", "аўторак", "серада", "чацвер", "пятніца", "субота"], ERANAMES: ["да н.э.", "н.э."], ERAS: ["да н.э.", "н.э."], FIRSTDAYOFWEEK: 0, MONTH: ["студзеня", "лютага", "сакавіка", "красавіка", "мая", "чэрвеня", "ліпеня", "жніўня", "верасня", "кастрычніка", "лістапада", "снежня"], SHORTDAY: ["нд", "пн", "аў", "ср", "чц", "пт", "сб"], SHORTMONTH: ["сту", "лют", "сак", "кра", "мая", "чэр", "ліп", "жні", "вер", "кас", "ліс", "сне"], WEEKENDRANGE: [5, 6], fullDate: "EEEE, d MMMM y", longDate: "d MMMM y", medium: "d.M.y HH.mm.ss", mediumDate: "d.M.y", mediumTime: "HH.mm.ss", short: "d.M.yy HH.mm", shortDate: "d.M.yy", shortTime: "HH.mm" }, NUMBER_FORMATS: { CURRENCY_SYM: "BYR", DECIMAL_SEP: ",", GROUP_SEP: " ", PATTERNS: [{ gSize: 3, lgSize: 3, maxFrac: 3, minFrac: 0, minInt: 1, negPre: "-", negSuf: "", posPre: "", posSuf: "" }, { gSize: 3, lgSize: 3, maxFrac: 2, minFrac: 2, minInt: 1, negPre: "-¤", negSuf: "", posPre: "¤", posSuf: "" }] }, id: "be-by", pluralCat: function (e, M) { return e % 10 == 1 && e % 100 != 11 ? E.ONE : e % 10 >= 2 && e % 10 <= 4 && (e % 100 < 12 || e % 100 > 14) ? E.FEW : e % 10 == 0 || e % 10 >= 5 && e % 10 <= 9 || e % 100 >= 11 && e % 100 <= 14 ? E.MANY : E.OTHER } }) }]);

﻿"use strict"; angular.module("ngLocale", [], ["$provide", function (e) { function r(e) { e += ""; var r = e.indexOf("."); return r == -1 ? 0 : e.length - r - 1 } function n(e, n) { var a = n; void 0 === a && (a = Math.min(r(e), 3)); var M = Math.pow(10, a), t = (e * M | 0) % M; return { v: a, f: t } } var a = { ZERO: "zero", ONE: "one", TWO: "two", FEW: "few", MANY: "many", OTHER: "other" }; e.value("$locale", { DATETIME_FORMATS: { AMPMS: ["vorm.", "nachm."], DAY: ["Sonntag", "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag"], ERANAMES: ["v. Chr.", "n. Chr."], ERAS: ["v. Chr.", "n. Chr."], FIRSTDAYOFWEEK: 0, MONTH: ["Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "September", "Oktober", "November", "Dezember"], SHORTDAY: ["So.", "Mo.", "Di.", "Mi.", "Do.", "Fr.", "Sa."], SHORTMONTH: ["Jan.", "Feb.", "März", "Apr.", "Mai", "Juni", "Juli", "Aug.", "Sep.", "Okt.", "Nov.", "Dez."], WEEKENDRANGE: [5, 6], fullDate: "EEEE, d. MMMM y", longDate: "d. MMMM y", medium: "dd.MM.y HH:mm:ss", mediumDate: "dd.MM.y", mediumTime: "HH:mm:ss", short: "dd.MM.yy HH:mm", shortDate: "dd.MM.yy", shortTime: "HH:mm" }, NUMBER_FORMATS: { CURRENCY_SYM: "€", DECIMAL_SEP: ",", GROUP_SEP: ".", PATTERNS: [{ gSize: 3, lgSize: 3, maxFrac: 3, minFrac: 0, minInt: 1, negPre: "-", negSuf: "", posPre: "", posSuf: "" }, { gSize: 3, lgSize: 3, maxFrac: 2, minFrac: 2, minInt: 1, negPre: "-", negSuf: " ¤", posPre: "", posSuf: " ¤" }] }, id: "de", pluralCat: function (e, r) { var M = 0 | e, t = n(e, r); return 1 == M && 0 == t.v ? a.ONE : a.OTHER } }) }]);

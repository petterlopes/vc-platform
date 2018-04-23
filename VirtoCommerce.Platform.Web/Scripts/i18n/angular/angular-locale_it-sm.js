﻿"use strict"; angular.module("ngLocale", [], ["$provide", function (e) { function a(e) { e += ""; var a = e.indexOf("."); return a == -1 ? 0 : e.length - a - 1 } function o(e, o) { var r = o; void 0 === r && (r = Math.min(a(e), 3)); var n = Math.pow(10, r), m = (e * n | 0) % n; return { v: r, f: m } } var r = { ZERO: "zero", ONE: "one", TWO: "two", FEW: "few", MANY: "many", OTHER: "other" }; e.value("$locale", { DATETIME_FORMATS: { AMPMS: ["AM", "PM"], DAY: ["domenica", "lunedì", "martedì", "mercoledì", "giovedì", "venerdì", "sabato"], ERANAMES: ["a.C.", "d.C."], ERAS: ["aC", "dC"], FIRSTDAYOFWEEK: 0, MONTH: ["gennaio", "febbraio", "marzo", "aprile", "maggio", "giugno", "luglio", "agosto", "settembre", "ottobre", "novembre", "dicembre"], SHORTDAY: ["dom", "lun", "mar", "mer", "gio", "ven", "sab"], SHORTMONTH: ["gen", "feb", "mar", "apr", "mag", "giu", "lug", "ago", "set", "ott", "nov", "dic"], WEEKENDRANGE: [5, 6], fullDate: "EEEE d MMMM y", longDate: "d MMMM y", medium: "dd MMM y HH:mm:ss", mediumDate: "dd MMM y", mediumTime: "HH:mm:ss", short: "dd/MM/yy HH:mm", shortDate: "dd/MM/yy", shortTime: "HH:mm" }, NUMBER_FORMATS: { CURRENCY_SYM: "€", DECIMAL_SEP: ",", GROUP_SEP: ".", PATTERNS: [{ gSize: 3, lgSize: 3, maxFrac: 3, minFrac: 0, minInt: 1, negPre: "-", negSuf: "", posPre: "", posSuf: "" }, { gSize: 3, lgSize: 3, maxFrac: 2, minFrac: 2, minInt: 1, negPre: "-", negSuf: " ¤", posPre: "", posSuf: " ¤" }] }, id: "it-sm", pluralCat: function (e, a) { var n = 0 | e, m = o(e, a); return 1 == n && 0 == m.v ? r.ONE : r.OTHER } }) }]);

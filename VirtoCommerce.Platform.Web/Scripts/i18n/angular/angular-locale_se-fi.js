﻿"use strict"; angular.module("ngLocale", [], ["$provide", function (a) { function e(a) { a += ""; var e = a.indexOf("."); return e == -1 ? 0 : a.length - e - 1 } function n(a, n) { var o = n; void 0 === o && (o = Math.min(e(a), 3)); var u = Math.pow(10, o), m = (a * u | 0) % u; return { v: o, f: m } } var o = { ZERO: "zero", ONE: "one", TWO: "two", FEW: "few", MANY: "many", OTHER: "other" }; a.value("$locale", { DATETIME_FORMATS: { AMPMS: ["iđitbeaivet", "eahketbeaivet"], DAY: ["aejlege", "måanta", "däjsta", "gaskevahkoe", "dåarsta", "bearjadahke", "laavadahke"], ERANAMES: ["ovdal Kristtusa", "maŋŋel Kristtusa"], ERAS: ["o.Kr.", "m.Kr."], FIRSTDAYOFWEEK: 0, MONTH: ["ođđajagemánnu", "guovvamánnu", "njukčamánnu", "cuoŋománnu", "miessemánnu", "geassemánnu", "suoidnemánnu", "borgemánnu", "čakčamánnu", "golggotmánnu", "skábmamánnu", "juovlamánnu"], SHORTDAY: ["sotn", "vuos", "maŋ", "gask", "duor", "bear", "láv"], SHORTMONTH: ["ođđajage", "guovva", "njukča", "cuoŋo", "miesse", "geasse", "suoidne", "borge", "čakča", "golggot", "skábma", "juovla"], WEEKENDRANGE: [5, 6], fullDate: "y MMMM d, EEEE", longDate: "y MMMM d", medium: "y MMM d HH:mm:ss", mediumDate: "y MMM d", mediumTime: "HH:mm:ss", short: "y-MM-dd HH:mm", shortDate: "y-MM-dd", shortTime: "HH:mm" }, NUMBER_FORMATS: { CURRENCY_SYM: "€", DECIMAL_SEP: ",", GROUP_SEP: " ", PATTERNS: [{ gSize: 3, lgSize: 3, maxFrac: 3, minFrac: 0, minInt: 1, negPre: "-", negSuf: "", posPre: "", posSuf: "" }, { gSize: 3, lgSize: 3, maxFrac: 2, minFrac: 2, minInt: 1, negPre: "-", negSuf: " ¤", posPre: "", posSuf: " ¤" }] }, id: "se-fi", pluralCat: function (a, e) { var u = 0 | a, m = n(a, e); return 1 == u && 0 == m.v ? o.ONE : o.OTHER } }) }]);

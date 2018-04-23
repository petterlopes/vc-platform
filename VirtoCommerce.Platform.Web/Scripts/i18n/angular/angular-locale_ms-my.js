﻿"use strict"; angular.module("ngLocale", [], ["$provide", function (e) { var a = { ZERO: "zero", ONE: "one", TWO: "two", FEW: "few", MANY: "many", OTHER: "other" }; e.value("$locale", { DATETIME_FORMATS: { AMPMS: ["PG", "PTG"], DAY: ["Ahad", "Isnin", "Selasa", "Rabu", "Khamis", "Jumaat", "Sabtu"], MONTH: ["Januari", "Februari", "Mac", "April", "Mei", "Jun", "Julai", "Ogos", "September", "Oktober", "November", "Disember"], SHORTDAY: ["Ahd", "Isn", "Sel", "Rab", "Kha", "Jum", "Sab"], SHORTMONTH: ["Jan", "Feb", "Mac", "Apr", "Mei", "Jun", "Jul", "Ogos", "Sep", "Okt", "Nov", "Dis"], fullDate: "EEEE, d MMMM y", longDate: "d MMMM y", medium: "dd/MM/yyyy h:mm:ss a", mediumDate: "dd/MM/yyyy", mediumTime: "h:mm:ss a", short: "d/MM/yy h:mm a", shortDate: "d/MM/yy", shortTime: "h:mm a" }, NUMBER_FORMATS: { CURRENCY_SYM: "RM", DECIMAL_SEP: ".", GROUP_SEP: ",", PATTERNS: [{ gSize: 3, lgSize: 3, macFrac: 0, maxFrac: 3, minFrac: 0, minInt: 1, negPre: "-", negSuf: "", posPre: "", posSuf: "" }, { gSize: 3, lgSize: 3, macFrac: 0, maxFrac: 2, minFrac: 2, minInt: 1, negPre: "(¤", negSuf: ")", posPre: "¤", posSuf: "" }] }, id: "ms-my", pluralCat: function (e) { return a.OTHER } }) }]);

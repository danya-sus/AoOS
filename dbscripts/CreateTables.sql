
CREATE TABLE IF NOT EXISTS "vehicles" (
	"code" VARCHAR NOT NULL,
	"name" VARCHAR NOT NULL,
	"year" INTEGER NOT NULL,
	PRIMARY KEY ("code")
);

INSERT INTO "vehicles" VALUES (
	"NEW123A", "AUDI80", 2010
);

INSERT INTO "vehicles" VALUES (
	"NEW123B", "AUDI100", 2009
);

INSERT INTO "vehicles" VALUES (
	"NEW123C", "AUDI200", 2008
);

INSERT INTO "vehicles" VALUES (
	"NEW123D", "AUDITT", 2007
);

INSERT INTO "vehicles" VALUES (
	"NEW123E", "AUDIR8", 2006
);

INSERT INTO "vehicles" VALUES (
	"NEW123F", "AUDIS8", 2005
);

INSERT INTO "vehicles" VALUES (
	"NEW123G", "AUDIQ5", 2004
);

INSERT INTO "vehicles" VALUES (
	"NEW123H", "AUDIA3", 2003
);
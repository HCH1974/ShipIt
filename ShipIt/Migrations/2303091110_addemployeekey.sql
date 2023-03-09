alter table em drop constraint em_pkey;
ALTER TABLE em ADD COLUMN id SERIAL PRIMARY KEY;
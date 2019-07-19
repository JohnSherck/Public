DELETE FROM reservation;
DELETE FROM site;
DELETE FROM campground
DELETE FROM PARK

-- Acadia
INSERT INTO park (name, location, establish_date, area, visitors, description)
VALUES ('Acadia', 'Maine', '1919-02-26', 47389, 2563129, 'Covering most of Mount Desert Island and other coastal islands, Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes. There are freshwater, estuary, forest, and intertidal habitats.');
DECLARE @park1 int = (SELECT @@IDENTITY);

-- Arches
INSERT INTO park (name, location, establish_date, area, visitors, description)
VALUES ('Arches',	'Utah', '1929-04-12', 76518,	1284767, 'This site features more than 2,000 natural sandstone arches, including the famous Delicate Arch. In a desert climate, millions of years of erosion have led to these structures, and the arid ground has life-sustaining soil crust and potholes, which serve as natural water-collecting basins. Other geologic formations are stone columns, spires, fins, and towers.');
DECLARE @park2 int = (SELECT @@IDENTITY);

-- Cuyahoga
INSERT INTO park (name, location, establish_date, area, visitors, description)
VALUES ('Cuyahoga Valley', 'Ohio', '2000-10-11',32860,	2189849, 'This park along the Cuyahoga River has waterfalls, hills, trails, and exhibits on early rural living. The Ohio and Erie Canal Towpath Trail follows the Ohio and Erie Canal, where mules towed canal boats. The park has numerous historic homes, bridges, and structures, and also offers a scenic train ride.');
DECLARE @park3 int = (SELECT @@IDENTITY);

-- Acadia Campgrounds
INSERT INTO campground (park_id, name, open_from_mm, open_to_mm, daily_fee) VALUES (@park1, 'Blackwoods', 1, 12, 35.00);
DECLARE @campg1 int = (SELECT @@IDENTITY);
INSERT INTO campground (park_id, name, open_from_mm, open_to_mm, daily_fee) VALUES (@park1, 'Seawall', 5, 9, 30.00);
DECLARE @campg2 int = (SELECT @@IDENTITY);
INSERT INTO campground (park_id, name, open_from_mm, open_to_mm, daily_fee) VALUES (@park1, 'Schoodic Woods', 5, 10, 30.00);
DECLARE @campg3 int = (SELECT @@IDENTITY);

-- Arches Campgrounds
INSERT INTO campground (park_id, name, open_from_mm, open_to_mm, daily_fee) VALUES (@park2, 'Devil''s Garden', 1, 12, 25.00);
DECLARE @campg4 int = (SELECT @@IDENTITY);
INSERT INTO campground (park_id, name, open_from_mm, open_to_mm, daily_fee) VALUES (@park2, 'Canyon Wren Group Site', 1, 12, 160.00);
DECLARE @campg5 int = (SELECT @@IDENTITY);
INSERT INTO campground (park_id, name, open_from_mm, open_to_mm, daily_fee) VALUES (@park2, 'Juniper Group Site', 1, 12, 250.00);
DECLARE @campg6 int = (SELECT @@IDENTITY);

-- Cuyahoga Campgrounds
INSERT INTO campground (park_id, name, open_from_mm, open_to_mm, daily_fee) VALUES (@park3, 'The Unnamed Primitive Campsites', 5, 11, 20.00);
DECLARE @campg7 int = (SELECT @@IDENTITY);

-- Acadia Blackwoods Sites (Tent, Camper)
INSERT INTO site (site_number, campground_id) VALUES (1, @campg1);
DECLARE @cs1 int = (SELECT @@IDENTITY);
INSERT INTO site (site_number, campground_id) VALUES (2, @campg1);
DECLARE @cs2 int = (SELECT @@IDENTITY);
INSERT INTO site (site_number, campground_id) VALUES (3, @campg1);
DECLARE @cs3 int = (SELECT @@IDENTITY);
INSERT INTO site (site_number, campground_id, utilities) VALUES (4, @campg1, 1);
DECLARE @cs4 int = (SELECT @@IDENTITY);
INSERT INTO site (site_number, campground_id, accessible) VALUES (5, @campg1, 1);
INSERT INTO site (site_number, campground_id, accessible, utilities) VALUES (6, @campg1, 1, 1);
-- Acadia Blackwoods Sites (RV/Trainler 20ft)
INSERT INTO site (site_number, campground_id, max_rv_length) VALUES (7, @campg1, 20);
DECLARE @cs7 int = (SELECT @@IDENTITY);
INSERT INTO site (site_number, campground_id, max_rv_length, utilities) VALUES (8, @campg1, 20, 1);
INSERT INTO site (site_number, campground_id, max_rv_length, accessible, utilities) VALUES (9, @campg1, 20, 1, 1);
DECLARE @cs9 int = (SELECT @@IDENTITY);
-- Acadia Blackwoods Sites (RV/Trainler 35ft)
INSERT INTO site (site_number, campground_id, max_rv_length) VALUES (10, @campg1, 35);
DECLARE @cs10 int = (SELECT @@IDENTITY);
INSERT INTO site (site_number, campground_id, max_rv_length, utilities) VALUES (11, @campg1, 35, 1);
INSERT INTO site (site_number, campground_id, max_rv_length, accessible, utilities) VALUES (12, @campg1, 35, 1, 1);

-- Acadia Seawall Sites (Tent)
INSERT INTO site (site_number, campground_id) VALUES (1, @campg2);
DECLARE @cs13 int = (SELECT @@IDENTITY);
INSERT INTO site (site_number, campground_id) VALUES (2, @campg2);
DECLARE @cs14 int = (SELECT @@IDENTITY);
INSERT INTO site (site_number, campground_id, utilities) VALUES (3, @campg2, 1);
DECLARE @cs15 int = (SELECT @@IDENTITY);
INSERT INTO site (site_number, campground_id, accessible) VALUES (4, @campg2, 1);
DECLARE @cs16 int = (SELECT @@IDENTITY);
INSERT INTO site (site_number, campground_id, accessible) VALUES (5, @campg2, 1);
DECLARE @cs17 int = (SELECT @@IDENTITY);
INSERT INTO site (site_number, campground_id, accessible, utilities) VALUES (6, @campg2, 1, 1);
DECLARE @cs18 int = (SELECT @@IDENTITY);
-- Acadia Seawall Sites (RV/Trailer 20ft)
INSERT INTO site (site_number, campground_id, max_rv_length) VALUES (7, @campg2, 20);
DECLARE @cs19 int = (SELECT @@IDENTITY);
INSERT INTO site (site_number, campground_id, max_rv_length, utilities) VALUES (8, @campg2, 20, 1);
DECLARE @cs20 int = (SELECT @@IDENTITY);
INSERT INTO site (site_number, campground_id, max_rv_length, accessible, utilities) VALUES (9, @campg2, 20, 1, 1);
INSERT INTO site (site_number, campground_id, max_rv_length, accessible, utilities) VALUES (10, @campg2, 20, 1, 1);
-- Acadia Seawall Sites (RV/Trailer 35ft)
INSERT INTO site (site_number, campground_id, max_rv_length, utilities) VALUES (11, @campg2, 35, 1);
INSERT INTO site (site_number, campground_id, max_rv_length, accessible, utilities) VALUES (12, @campg2, 35, 1, 1);
DECLARE @cs24 int = (SELECT @@IDENTITY);

-- Acadia Schoodic Sites (Tent and Camper)
INSERT INTO site (site_number, campground_id) VALUES (1, @campg3);
DECLARE @cs25 int = (SELECT @@IDENTITY);
INSERT INTO site (site_number, campground_id) VALUES (2, @campg3);
INSERT INTO site (site_number, campground_id, utilities) VALUES (3, @campg3, 1); -- 31 - 35
INSERT INTO site (site_number, campground_id, accessible, utilities) VALUES (4, @campg3, 1, 1);
DECLARE @cs28 int = (SELECT @@IDENTITY);
-- Acadia Schoodic Sites (RV/Trailer 20ft)
INSERT INTO site (site_number, campground_id, max_rv_length) VALUES (5, @campg3, 20);
DECLARE @cs29 int = (SELECT @@IDENTITY);
INSERT INTO site (site_number, campground_id, max_rv_length, utilities) VALUES (6, @campg3, 20, 1);
INSERT INTO site (site_number, campground_id, max_rv_length, utilities) VALUES (7, @campg3, 20, 1);
DECLARE @cs31 int = (SELECT @@IDENTITY);
INSERT INTO site (site_number, campground_id, max_rv_length, accessible, utilities) VALUES (8, @campg3, 20, 1, 1); -- 21 - 22
DECLARE @cs32 int = (SELECT @@IDENTITY);
-- Acadia Schoodic Sites (RV/Trailer 35ft)
INSERT INTO site (site_number, campground_id, max_rv_length) VALUES (9, @campg3, 35); -- 1 - 10
INSERT INTO site (site_number, campground_id, max_rv_length, utilities) VALUES (10, @campg3, 35, 1);
INSERT INTO site (site_number, campground_id, max_rv_length, accessible) VALUES (11, @campg3, 35, 1);
INSERT INTO site (site_number, campground_id, max_rv_length, accessible, utilities) VALUES (12, @campg3, 35, 1, 1);

-- Arches Devil's Garden Sites (Tent)
INSERT INTO site (site_number, campground_id, max_occupancy) VALUES (1, @campg4, 10);
DECLARE @cs37 int = (SELECT @@IDENTITY);
INSERT INTO site (site_number, campground_id, max_occupancy) VALUES (2, @campg4, 10);
INSERT INTO site (site_number, campground_id, max_occupancy, utilities) VALUES (3, @campg4, 10, 1);
INSERT INTO site (site_number, campground_id, max_occupancy, utilities) VALUES (4, @campg4, 10, 1);
DECLARE @cs40 int = (SELECT @@IDENTITY);
INSERT INTO site (site_number, campground_id, max_occupancy, accessible, utilities) VALUES (5, @campg4, 10, 1, 1);
INSERT INTO site (site_number, campground_id, max_occupancy, accessible, utilities) VALUES (6, @campg4, 10, 1, 1);
DECLARE @cs42 int = (SELECT @@IDENTITY);
-- Arches Devil's Garden Sites (RV/Trailer 20ft)
INSERT INTO site (site_number, campground_id, max_occupancy, max_rv_length, utilities) VALUES (7, @campg4, 7, 20, 1);
DECLARE @cs43 int = (SELECT @@IDENTITY);
INSERT INTO site (site_number, campground_id, max_occupancy, max_rv_length, utilities) VALUES (8, @campg4, 7, 20, 1);
DECLARE @cs44 int = (SELECT @@IDENTITY);
 -- Arches Canyon Wren Group Site (Tent)
INSERT INTO site (site_number, campground_id, max_occupancy, accessible) VALUES (1, @campg5, 35, 1);
DECLARE @cs45 int = (SELECT @@IDENTITY);
-- Arches Juniper Group Site (Tent)
INSERT INTO site (site_number, campground_id, max_occupancy, accessible) VALUES (1, @campg6, 55, 1);
DECLARE @cs46 int = (SELECT @@IDENTITY);

-- Cuyahoga Unnamed Primitive Campsites Sites (Tent)
INSERT INTO site (site_number, campground_id) VALUES (1, @campg7);
INSERT INTO site (site_number, campground_id) VALUES (2, @campg7);
INSERT INTO site (site_number, campground_id) VALUES (3, @campg7);
INSERT INTO site (site_number, campground_id) VALUES (4, @campg7);
INSERT INTO site (site_number, campground_id) VALUES (5, @campg7);



-- Reservations
-- Acadia Blackwoods Sites (1 - 12)
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs1, 'Smith Family Reservation', GETDATE()-2, GETDATE()+2);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs1, 'Lockhart Family Reservation', GETDATE()-6, GETDATE()-3);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs2, 'Jones Reservation', GETDATE()-2, GETDATE()+2);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs3, 'Bauer Family Reservation', GETDATE(), GETDATE()+2);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs4, 'Eagles Family Reservation', GETDATE()+5, GETDATE()+10);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs7, 'Aersomith Reservation', GETDATE()-3, GETDATE()+2);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs9, 'Claus Family Reservation', GETDATE(), GETDATE()+1);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs9, 'Taylor Family Reservation', GETDATE()-7, GETDATE()-5);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs10, 'Astley Family Reservation', GETDATE()+14, GETDATE()+21);

-- Acadia Seawall Sites (13 - 24)
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs13, 'Jobs Family Reservation', GETDATE()+1, GETDATE()+4);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs14, 'Cook Family Reservation', GETDATE()+1, GETDATE()+4);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs15, 'Gates Reservation', GETDATE()+1, GETDATE()+4);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs16, 'Cue Family Reservation', GETDATE()+1, GETDATE()+4);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs17, 'Ive Family Reservation', GETDATE()+1, GETDATE()+4);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs18, 'Federighi Family Reservation', GETDATE()+1, GETDATE()+4);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs19, 'Schiller Family Reservation', GETDATE()+1, GETDATE()+4);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs20, 'Williams Family Reservation', GETDATE()+1, GETDATE()+4);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs20, 'Kawasaki Family Reservation', GETDATE()+10, GETDATE()+21);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs20, 'Branson Family Reservation', GETDATE()+22, GETDATE()+28);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs20, 'Zukerberg Family Reservation', GETDATE()+30, GETDATE()+33);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs24, 'Musk Family Reservation', GETDATE()+4, GETDATE()+10);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs24, 'Buffett Family Reservation', GETDATE()-4, GETDATE());

-- Acadia Schoodic Woods Sites (25 - 36)
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs25, 'Satya Nedella', GETDATE()+3, GETDATE()+10);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs25, 'Scott Gutherie', GETDATE()+10, GETDATE()+14);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs28, 'Amy Hood', GETDATE()+5, GETDATE()+11);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs29, 'Peggy Johnson', GETDATE()+5, GETDATE()+11);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs31, 'Terry Myerson', GETDATE()+9, GETDATE()+11);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs32, 'Steve Ballmer', GETDATE()+13, GETDATE()+15);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs32, 'Gates Family Reservation', GETDATE()+16, GETDATE()+19);


-- Devil's Garden (37 - 44)
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs37, 'Marisa Mayer', GETDATE()-15, GETDATE()-10);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs37, 'Beth Mooney', GETDATE(), GETDATE()+4);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs40, 'William Priemer', GETDATE()+2, GETDATE()+6);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs42, 'Tricia Griffith', GETDATE()+3, GETDATE()+8);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs43, 'Toby Cosgrove', GETDATE()+5, GETDATE()+11);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs43, 'Akram Boutros', GETDATE()+12, GETDATE()+18);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs44, 'Barbara Snyder', GETDATE()+9, GETDATE()+11);


-- Canyon Wren (45)
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs45, 'Bill Board', GETDATE()-9, GETDATE()+1);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs45, 'Bill Loney', GETDATE()+1, GETDATE()+11);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs45, 'Cara Van', GETDATE()+17, GETDATE()+21);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs45, 'Forrest Gump', GETDATE()+31, GETDATE()+37);

-- Juniper Group Site (46)
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs46, 'Simpson Family', GETDATE()-6, GETDATE()+1);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs46, 'Smith Family', GETDATE()+2, GETDATE()+11);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs46, 'Leela Family', GETDATE()+14, GETDATE()+15);
INSERT INTO reservation (site_id, name, from_date, to_date) VALUES (@cs46, 'Scott Family', GETDATE()+35, GETDATE()+40);


-- Unnamed Primitive Campsites (47 - 51)


ALTER TABLE campground ADD FOREIGN KEY (park_id) REFERENCES park(park_id);
ALTER TABLE site ADD FOREIGN KEY (campground_id) REFERENCES campground(campground_id);
ALTER TABLE reservation ADD FOREIGN KEY (site_id) REFERENCES site(site_id);

SELECT @park1 AS AcadiaID, @campg1 AS BlackwoodsID, @cs1 AS campsite1ID
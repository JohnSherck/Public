		--list reservations in a given park
		SELECT * FROM reservation where site_id in 
			(SELECT site_id FROM site where campground_id in (
			SELECT campground_id FROM campground WHERE park_id = 1))

		--List site IDs, their campgrounds, and their Park.
		SELECT p.name Park, c.campground_id, c.name Campground, s.site_id FROM site s
			JOIN campground c on s.campground_id = c.campground_id
			JOIN park p on p.park_id = c.park_id
		WHERE p.park_id = 2		--optional - limit by parkID

		--List campgrounds by ParkId
		SELECT * from campground
			WHERE park_id = 3
		
		--Check reservations on a given site
		SELECT * from reservation where site_id = 45

		--See existing reservations at a given campground
		SELECT * from reservation where site_id in
			(SELECT site_id from site where campground_id = 6)

		--gets all available sites on given dates at a given campground
		DECLARE @startDate DATETIME
		DECLARE @endDate DATETIME
		SET @startDate='2019-07-04'
		SET @endDate='2019-07-06'
		
		SELECT * from site where site_id not in 
			(select site_id from reservation where site_id in 
				(SELECT site_id from site WHERE campground_id = 7) 
			and (from_date between @startDate and @endDate
				or to_date between @startDate and @endDate 
					or @startDate between from_Date and  to_Date)) 
			and campground_id = 7

		--get info about the campgrounds
		SELECT park.park_id, park.name, campground.campground_id, campground.name FROM campground 
			JOIN park on park.park_id = campground.park_id

			SELECT * FROM reservation 
				--JOIN site on site.site_id = reservation.site_id
				where reservation.site_id = 7
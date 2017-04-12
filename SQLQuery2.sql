

SELECT c.pr_ID, name, address from (rent_unit c join Property p on (p.pr_id = c.pr_id)), person pp, rent_unit ss where c.pr_id = ss.pr_id and pp.p_ID = owner_ID and c.pr_ID in (select pr_ID from rent_unit);

select * from commercial_unit

	use realestate
	SELECT c.pr_ID, name, p.address, ss.price, sqfeet, storage, ss.availability from (commercial_unit c join Property p on (p.pr_id = c.pr_id)), person pp, sale_unit ss where c.pr_id = ss.pr_id and pp.p_ID = owner_ID and c.pr_ID in (select pr_ID from sale_unit);

	select * from sale_unit
SELECT c.pr_ID, name, p.address, ss.price, bhk, furnished, ss.availability from (residential_unit c join Property p on (p.pr_id = c.pr_id)), person pp, sale_unit ss where c.pr_id = ss.pr_id and pp.p_ID = owner_ID and c.pr_ID in (select pr_ID from sale_unit);


 select * from person
 alter table person drop coumn  p_ID;
 drop database realestate
use avtoprokat;

select  avtomobil.id as 'id',
		avtomobil.nalichie as 'Наличие',
        marka.nazvanie as 'Марка',
        model.nazvanie as 'Модель', 
        kuzov.nazvanie as 'Кузов', 
        avtomobil.moshnost as 'Мощность', 
        tehosmotr.ispravnost as 'Исправность',
        strahovanie.kompaniya as 'Страховка',
        tarif.cena_za_sutki as 'Цена за сутки'
from avtomobil inner join marka on avtomobil.id_marka = marka.id
	 inner join model on avtomobil.id_model = model.id
	 inner join kuzov on avtomobil.id_kuzov = kuzov.id
	 inner join tehosmotr on avtomobil.id_tehosmotr = tehosmotr.id
	 inner join tarif on avtomobil.id_tarif = tarif.id
     inner join strahovanie on avtomobil.id_strahovanie = strahovanie.id
order by avtomobil.nalichie
;
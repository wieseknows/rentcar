use avtoprokat;
select avtomobil.id as 'id',
		avtomobil.nalichie as 'Наличие',
        marka.nazvanie as 'Марка',
        model.nazvanie as 'Модель', 
        kuzov.nazvanie as 'Кузов', 
        avtomobil.moshnost as 'Мощность', 
        tehosmotr.ispravnost as 'Исправность',
        strahovanie.kompaniya as 'Страховка',
        tarif.cena_za_sutki as 'Цена за сутки'
from  avtomobil join marka on avtomobil.id_marka = marka.id
				join kuzov on avtomobil.id_kuzov = kuzov.id
                join tarif on avtomobil.id_tarif = tarif.id
                join tehosmotr on avtomobil.id_tehosmotr = tehosmotr.id
                join model on avtomobil.id_model=model.id
                join strahovanie on strahovanie.id=avtomobil.id_strahovanie
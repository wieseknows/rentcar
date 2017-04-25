use avtoprokat;
SELECT  klient.familiya as 'Фамилия', 
		klient.imya as 'Имя', 
		klient.otchestvo as 'Отчество',
		voditelskie_prava.kategoriya as 'Категория', 
		concat(pasport.seriya, pasport.nomer) as 'Паспорт',
        medic_spravka.zdorovie as 'Мед. Обслед.', 
        concat(adres.gorod, ', ул.', adres.ulica, ', д.', adres.dom, ', кв.', adres.kvartira) as 'Адрес'
FROM 	klient join voditelskie_prava on klient.id_voditelskie_prava = voditelskie_prava.id
			   join pasport on klient.id_pasport = pasport.id
               join medic_spravka on klient.id_medic_spravka = medic_spravka.id
               join adres on klient.id_adres = adres.id
ORDER BY klient.familiya
;
        
        
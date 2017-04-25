use avtoprokat;
SELECT zakaz.id, 
	   marka.nazvanie,
       concat(sotrudnik.familiya, ' ', sotrudnik.imya, ' ', sotrudnik.otchestvo) as 'fio',
       zakaz.data
from zakaz join klient on zakaz.id_klient = klient.id 
		   join avtomobil on zakaz.id_avtomobil = avtomobil.id 
           join marka on avtomobil.id_marka = marka.id 
           join model on avtomobil.id_model = model.id
           join sotrudnik on zakaz.id_sotrudnik = sotrudnik.id
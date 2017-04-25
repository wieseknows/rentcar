use avtoprokat;
SELECT zakaz.id as 'Номер', concat(klient.familiya, ', ', klient.imya, ' ', klient.otchestvo) as 'Ф.И.О клиента',
	   concat(marka.nazvanie, ' ', model.nazvanie) as 'Машина',
       concat(sotrudnik.familiya, ' ', sotrudnik.imya) as 'Оформил',
       zakaz.data as 'Дата заказа'
from zakaz join klient on zakaz.id_klient = klient.id 
		   join avtomobil on zakaz.id_avtomobil = avtomobil.id 
           join marka on avtomobil.id_marka = marka.id 
           join model on avtomobil.id_model = model.id
           join sotrudnik on zakaz.id_sotrudnik = sotrudnik.id
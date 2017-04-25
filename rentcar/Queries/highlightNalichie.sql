use avtoprokat;

select avtomobil.id
from avtomobil inner join tehosmotr on avtomobil.id_tehosmotr = tehosmotr.id
where nalichie='В наличии' and tehosmotr.ispravnost='Исправен';
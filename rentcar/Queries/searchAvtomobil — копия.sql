use avtoprokat;
select avtomobil.id, avtomobil.moshnost, tarif.cena_za_sutki, kuzov.nazvanie as kuzov, marka.nazvanie as marka, tehosmotr.ispravnost as ispravnost
from  avtomobil join marka on avtomobil.id_marka = marka.id
				join kuzov on avtomobil.id_kuzov = kuzov.id
                join tarif on avtomobil.id_tarif = tarif.id
                join tehosmotr on avtomobil.id_tehosmotr = tehosmotr.id
                
                
                
select p.PersonelID, p.Adi, p.Soyadi, p.Telefonu, p.Adres, p.Email, d.Departman, p.Durumu, p.Maasi, p.GirisTarihi, p.Aciklama
from Personeller p, Departmanlar d
where p.DepartmanID = d.DepartmanID
using bank;

Klient klient = new Klient();
klient.kontoOsobiste.zdeponuj(299);
klient.kontoOszczednosciowe.zdeponuj(500);
klient.kontoFinansowe.zdeponuj(1000);
klient.stanKonta();
using z2.Models;

Factory factory = new Factory("Савушкин","Сидоров", 123122);
factory.Work();

OilCompany oilCompany = new OilCompany("БелНефть", "Иванов", 12412214);
oilCompany.PumpOil();

InsuranceСompany insuranceСompany = new InsuranceСompany("БелСтрах", "Тутчев", 124124124);
insuranceСompany.InsureOrgan(oilCompany);
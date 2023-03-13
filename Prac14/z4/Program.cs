using z4.Model;

Blogger blogger = new Blogger("MakiMails");

Subscriber subscriber = new Subscriber("Alex");
Moderator moderator = new Moderator("123456");


blogger.Attach(subscriber);
blogger.Attach(moderator);

blogger.CreateNewVideo("24/7 пишу код =)");

blogger.Detach(subscriber);

blogger.CreateNewVideo("Пишу код");
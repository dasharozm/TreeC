internal class People
{
    private int id;
    private string personName;
    private string gender;
    private string dateOfBitrh;
    private string mother;
    private string father;
    private string maritalStatus;
    private string partner;

    static List<People> membersOfFamily()
    {

        People person1 = new People
        {
            id = 1,
            personName = "Романов Николай Аександрович",
            gender = "Мужской",
            dateOfBitrh = "18.5.1868",
            mother = "Романова Мария Федоровна",
            father = "Романов Александр Александрович",
            maritalStatus = "Женат",
            partner = "Романова Александра Федоровна"
        };

        People person2 = new People
        {
            id = 2,
            personName = "Романова Александра Федоровна",
            gender = "Женский",
            dateOfBitrh = "6.6.1872",
            mother = "Гессенская Алиса",
            father = "Гессенский Людвиг",
            maritalStatus = "Замужем",
            partner = "Романов Николай Аександрович"
        };

        People person3 = new People
        {
            id = 3,
            personName = "Романова Ольга Николаевна",
            gender = "Женский",
            dateOfBitrh = "3.11.1895",
            mother = "Романова Александра Федоровна",
            father = "Романов Николай Аександрович",
            maritalStatus = "Не замужем",
            partner = "Нет"
        };

        People person4 = new People
        {
            id = 4,
            personName = "Романова Татьяна Николаевна",
            gender = "Женский",
            dateOfBitrh = "10.6.1897",
            mother = "Романова Александра Федоровна",
            father = "Романов Николай Аександрович",
            maritalStatus = "Не замужем",
            partner = "Нет"
        };

        People person5 = new People
        {
            id = 5,
            personName = "Романова Мария Николаевна",
            gender = "Женский",
            dateOfBitrh = "26.6.1899",
            mother = "Романова Александра Федоровна",
            father = "Романов Николай Аександрович",
            maritalStatus = "Не замужем",
            partner = "Нет"
        };

        People person6 = new People
        {
            id = 6,
            personName = "Романова Анастасия Николаевна",
            gender = "Женский",
            dateOfBitrh = "18.6.1901",
            mother = "Романова Александра Федоровна",
            father = "Романов Николай Аександрович",
            maritalStatus = "Не замужем",
            partner = "Нет"
        };

        People person7 = new People
        {
            id = 7,
            personName = "Романов Алексей Николаевич",
            gender = "Мужской",
            dateOfBitrh = "12.8.1904",
            mother = "Романова Александра Федоровна",
            father = "Романов Николай Аександрович",
            maritalStatus = "Не женат",
            partner = "Нет"
        };

        People person8 = new People
        {
            id = 8,
            personName = "Романов Александр Александрович",
            gender = "Мужской",
            dateOfBitrh = "10.3.1845",
            mother = "Романова Мария Александровна",
            father = "Романов Александр Николаевич",
            maritalStatus = "Женат",
            partner = "Романова Мария Федоровна"
        };

        People person9 = new People
        {
            id = 9,
            personName = "Романова Мария Федоровна",
            gender = "Женский",
            dateOfBitrh = "26.11.1847",
            mother = "Глюксборг Луиза",
            father = "Глюксборг Кристиан",
            maritalStatus = "Замужем",
            partner = "Романов Александр Александрович"
        };

        People person10 = new People
        {
            id = 10,
            personName = "Гессенский Людвиг",
            gender = "Мужской",
            dateOfBitrh = "12.9.1837",
            mother = "Прусская Елизавета",
            father = "Гессенский Карл",
            maritalStatus = "Женат",
            partner = "Гессенская Алиса"
        };

        People person11 = new People
        {
            id = 11,
            personName = "Гессенская Алиса",
            gender = "Женский",
            dateOfBitrh = "25.4.1843",
            mother = "Александрина Виктория",
            father = "Альберт Саксен-Кобург-Готского",
            maritalStatus = "Замужем",
            partner = "Гессенский Людвиг"
        };

        People person12 = new People
        {
            id = 12,
            personName = "Романов Александр Аександрович",
            gender = "Мужской",
            dateOfBitrh = "26.5.1869",
            mother = "Романова Мария Федоровна",
            father = "Романов Александр Александрович",
            maritalStatus = "Не женат",
            partner = "Нет"
        };

        People person13 = new People
        {
            id = 13,
            personName = "Романов Георгий Аександрович",
            gender = "Мужской",
            dateOfBitrh = "27.4.1871",
            mother = "Романова Мария Федоровна",
            father = "Романов Александр Александрович",
            maritalStatus = "Не женат",
            partner = "Нет"
        };

        People person14 = new People
        {
            id = 14,
            personName = "Романова Ксения Аександровна",
            gender = "Женский",
            dateOfBitrh = "25.3.1875",
            mother = "Романова Мария Федоровна",
            father = "Романов Александр Александрович",
            maritalStatus = "Замужем",
            partner = "Романов Александр Михайлович"
        };

        List<People> familyMembers = new List<People>();
        familyMembers.Add(person1);
        familyMembers.Add(person2);
        familyMembers.Add(person3);
        familyMembers.Add(person4);
        familyMembers.Add(person5);
        familyMembers.Add(person6);
        familyMembers.Add(person7);
        familyMembers.Add(person8);
        familyMembers.Add(person9);
        familyMembers.Add(person10);
        familyMembers.Add(person11);
        familyMembers.Add(person12);
        familyMembers.Add(person13);
        familyMembers.Add(person14);
        return familyMembers;
    }
}
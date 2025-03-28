namespace TestTask.Services;

public class TravelRepository
{
    private List<Travel> _travels =
    [
        new Travel { Code = "000001", Period = "22.02.2024 - 27.02.2024", Cities = "Москва, Ярославль, Ижевск, Владимир", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
        new Travel { Code = "000002", Period = "22.02.2024 - 27.02.2024", Cities = "Москва", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
        new Travel { Code = "000003", Period = "22.02.2024 - 27.02.2024", Cities = "Москва, Ижевск, Владимир", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
        new Travel { Code = "000004", Period = "22.02.2024 - 27.02.2024", Cities = "Москва, Ярославль, Владимир", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
        new Travel { Code = "000005", Period = "22.02.2024 - 27.02.2024", Cities = "Москва, Ярославль, Владимир", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
        new Travel { Code = "000006", Period = "22.02.2024 - 27.02.2024", Cities = "Москва, Ярославль, Ижевск, Владимир", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
        new Travel { Code = "000007", Period = "22.02.2024 - 27.02.2024", Cities = "Москва, Ижевск, Владимир", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
        new Travel { Code = "000008", Period = "22.02.2024 - 27.02.2024", Cities = "Кременчуг-Константиновское, Петропавловск-Камчатский, Новосибирск, Волгоград", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
        new Travel { Code = "000009", Period = "22.02.2024 - 27.02.2024", Cities = "Кременчуг-Константиновское, Петропавловск-Камчатский, Новосибирск", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
        new Travel { Code = "000010", Period = "22.02.2024 - 27.02.2024", Cities = "Москва, Ярославль, Ижевск, Владимир", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
        new Travel { Code = "000011", Period = "22.02.2024 - 27.02.2024", Cities = "Москва, Ярославль, Владимир", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
        new Travel { Code = "000012", Period = "22.02.2024 - 27.02.2024", Cities = "Москва, Ярославль, Ижевск, Владимир", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
        new Travel { Code = "000013", Period = "22.02.2024 - 27.02.2024", Cities = "Москва, Ярославль, Ижевск, Владимир", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
        new Travel { Code = "000014", Period = "22.02.2024 - 27.02.2024", Cities = "Москва, Ярославль, Ижевск, Владимир", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
        new Travel { Code = "000015", Period = "22.02.2024 - 27.02.2024", Cities = "Москва, Ярославль, Ижевск, Владимир", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
        new Travel { Code = "000016", Period = "22.02.2024 - 27.02.2024", Cities = "Москва, Ярославль, Ижевск, Владимир", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
        new Travel { Code = "000017", Period = "22.02.2024 - 27.02.2024", Cities = "Москва, Ярославль, Ижевск, Владимир", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
        new Travel { Code = "000018", Period = "22.02.2024 - 27.02.2024", Cities = "Москва, Ярославль, Ижевск, Владимир", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
        new Travel { Code = "000019", Period = "22.02.2024 - 27.02.2024", Cities = "Москва, Ярославль, Ижевск, Владимир", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
        new Travel { Code = "000020", Period = "22.02.2024 - 27.02.2024", Cities = "Москва, Ярославль, Ижевск, Владимир", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
        new Travel { Code = "000021", Period = "22.02.2024 - 27.02.2024", Cities = "Москва, Ярославль, Ижевск, Владимир", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
        new Travel { Code = "000022", Period = "22.02.2024 - 27.02.2024", Cities = "Москва, Ярославль, Ижевск, Владимир", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
        new Travel { Code = "000023", Period = "22.02.2024 - 27.02.2024", Cities = "Москва, Ярославль, Ижевск, Владимир", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
        new Travel { Code = "000024", Period = "22.02.2024 - 27.02.2024", Cities = "Москва, Ярославль, Ижевск, Владимир", Status = "Документы", FactSum = 30000, PlanSum = 40000 },
    ];
    
    public List<Travel> GetAllTravels() => _travels;
}

public class Travel
{
    public string Code = "";
    public string Period = "";
    public decimal PlanSum;
    public decimal FactSum;
    public string Cities = "";
    public string Status = "";
}
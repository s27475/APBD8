using LinqTasks.Models;

namespace LinqTasks.Extensions;

public static class CustomExtensionMethods
{
    //Put your extension methods here
    public static IEnumerable<Emp> GetEmpsWithSubordinates(this IEnumerable<Emp> emps)
    {
        return emps.Where(x => emps.Any(y => y.Mgr != null && x.Empno == y.Mgr.Empno))
            .OrderBy(x => x.Ename)
            .ThenByDescending(x => x.Salary);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace
{
    public interface HouseFace<T> where T:new()
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        int Add(T t);
        /// <summary>
        /// 删除
        /// </summary>
        /// <typeparam name="I"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        int Del<I>(I id) where I : struct;
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        int Upt(T t);
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        List<T> Show();
        /// <summary>
        /// 通过ID查看信息
        /// </summary>
        /// <typeparam name="I"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetShowById<I>(I id) where I:struct;
    }
}

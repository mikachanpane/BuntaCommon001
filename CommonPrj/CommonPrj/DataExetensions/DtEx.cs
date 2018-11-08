using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CommonPrj.DataExetensions
{
    //TODO ラムダ式で操作
    /// <summary>
    /// データテーブル制御用
    /// </summary>
    static class DataExp
    {
        /// <summary>
        /// 重複行の検索
        /// </summary>
        /// 
        /// <returns></returns>
        static private DataRow RowEx(DataRow Row)
        {
            //TODO Unit
            var tst = "";

            //DataRowから、重複データを検索
            

            //カレント行編集結果
            return Row;
        }

        /// <summary>
        /// DataTableから重複行を検索し、除去した結果を返す
        /// </summary>
        /// <param name="Dt">対象DataTable</param>
        /// <returns>除去結果</returns>
        static private DataTable DtEx(DataTable Dt)
        {
            //格納するDataTable
            DataTable dt;



            //除去した結果を返却する
            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WpfSamples
{
// 财务报表表格
public class FinancialStatements
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 报告日期
    /// </summary>
    public DateTime ReportDate { get; set; }
    /// <summary>
    /// 收入
    /// </summary>
    public decimal Revenue { get; set; }
    /// <summary>
    /// 净收入
    /// </summary>
    public decimal NetIncome { get; set; }
    /// <summary>
    /// 每股收益
    /// </summary>
    public decimal EarningsPerShare { get; set; }
    /// <summary>
    /// 总资产
    /// </summary>
    public decimal TotalAssets { get; set; }
    /// <summary>
    /// 总负债
    /// </summary>
    public decimal TotalLiabilities { get; set; }
    /// <summary>
    /// 净资产
    /// </summary>
    public decimal TotalEquity { get; set; }
    /// <summary>
    /// 外键关联stocks表id字段
    /// </summary>
    public int StockId { get; set; }
}

// 股票基本信息表
public class Stocks
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票名称
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// 股票代码，唯一
    /// </summary>
    public string Symbol { get; set; }
    /// <summary>
    /// 交易所
    /// </summary>
    public string Exchange { get; set; }
    /// <summary>
    /// 行业
    /// </summary>
    public string Industry { get; set; }
    /// <summary>
    /// 市值
    /// </summary>
    public decimal MarketCap { get; set; }
    /// <summary>
    /// 上市日期
    /// </summary>
    public DateTime ListedDate { get; set; }
    /// <summary>
    /// 是否上市
    /// </summary>
    public bool IsActive { get; set; }
}

// 股票公告表
public class StockAnnouncements
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 公告日期
    /// </summary>
    public DateTime AnnouncementDate { get; set; }
    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// 内容
    /// </summary>
    public string Content { get; set; }
    /// <summary>
    /// 外键关联stocks表id字段
    /// </summary>
    public int StockId { get; set; }
}

// 股票历史价格表
public class StockPrices
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 价格日期
    /// </summary>
    public DateTime PriceDate { get; set; }
    /// <summary>
    /// 开盘价
    /// </summary>
    public decimal OpenPrice { get; set; }
    /// <summary>
    /// 最高价
    /// </summary>
    public decimal HighPrice { get; set; }
    /// <summary>
    /// 最低价
    /// </summary>
    public decimal LowPrice { get; set; }
    /// <summary>
    /// 收盘价
    /// </summary>
    public decimal ClosePrice { get; set; }
    /// <summary>
    /// 成交量
    /// </summary>
    public long Volume { get; set; }
    /// <summary>
    /// 外键关联stocks表id字段
    /// </summary>
    public int StockId { get; set; }
}

// 股票财务数据表
public class FinancialData
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 数据日期
    /// </summary>
    public DateTime DataDate { get; set; }
    /// <summary>
    /// 收入
    /// </summary>
    public decimal Revenue { get; set; }
    /// <summary>
    /// 净收入
    /// </summary>
    public decimal NetIncome { get; set; }
    /// <summary>
    /// 每股收益
    /// </summary>
    public decimal EarningsPerShare { get; set; }
    /// <summary>
    /// 总资产
    /// </summary>
    public decimal TotalAssets { get; set; }
    /// <summary>
    /// 总负债
    /// </summary>
    public decimal TotalLiabilities { get; set; }
    /// <summary>
    /// 净资产
    /// </summary>
    public decimal TotalEquity { get; set; }
    /// <summary>
    /// 外键关联stocks表id字段
    /// </summary>
    public int StockId { get; set; }
}

// 历史K线数据表格
public class KLineData
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 数据日期
    /// </summary>
    public DateTime DataDate { get; set; }
    /// <summary>
    /// 开盘价
    /// </summary>
    public decimal OpenPrice { get; set; }
    /// <summary>
    /// 最高价
    /// </summary>
    public decimal HighPrice { get; set; }
    /// <summary>
    /// 最低价
    /// </summary>
    public decimal LowPrice { get; set; }
    /// <summary>
    /// 收盘价
    /// </summary>
    public decimal ClosePrice { get; set; }
    /// <summary>
    /// 成交量
    /// </summary>
    public long Volume { get; set; }
    /// <summary>
    /// 外键关联stocks表id字段
    /// </summary>
    public int StockId { get; set; }
}

// 股票资讯表
public class StockNews
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 新闻日期
    /// </summary>
    public DateTime NewsDate { get; set; }
    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// 内容
    /// </summary>
    public string Content { get; set; }
    /// <summary>
    /// 外键关联stocks表id字段
    /// </summary>
    public int StockId { get; set; }
}

// 分红派息表
public class Dividends
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 除权日
    /// </summary>
    public DateTime ExDividendDate { get; set; }
    /// <summary>
    /// 分红金额
    /// </summary>
    public decimal DividendAmount { get; set; }
    /// <summary>
    /// 外键关联stocks表id字段
    /// </summary>
    public int StockId { get; set; }
}

// 股本变动表
public class ShareChanges
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 变动日期
    /// </summary>
    public DateTime ChangeDate { get; set; }
    /// <summary>
    /// 流通股数
    /// </summary>
    public long OutstandingShares { get; set; }
    /// <summary>
    /// 外键关联stocks表id字段
    /// </summary>
    public int StockId { get; set; }
}

// 股东持股表
public class ShareholderHoldings
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 持股日期
    /// </summary>
    public DateTime HoldingDate { get; set; }
    /// <summary>
    /// 股东名称
    /// </summary>
    public string ShareholderName { get; set; }
    /// <summary>
    /// 持有股数
    /// </summary>
    public long SharesOwned { get; set; }
    /// <summary>
    /// 外键关联stocks表id字段
    /// </summary>
    public int StockId { get; set; }
}

// 董事会决议表
public class BoardResolutions
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 决议日期
    /// </summary>
    public DateTime ResolutionDate { get; set; }
    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// 内容
    /// </summary>
    public string Content { get; set; }
    /// <summary>
    /// 外键关联stocks表id字段
    /// </summary>
    public int StockId { get; set; }
}

// 股票交易记录表
public class StockTrades
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 交易日期
    /// </summary>
    public DateTime TradeDate { get; set; }
    /// <summary>
    /// 买卖指示（B为买入，S为卖出）
    /// </summary>
    public char BuySellIndicator { get; set; }
    /// <summary>
    /// 数量
    /// </summary>
    public long Quantity { get; set; }
    /// <summary>
    /// 成交价格
    /// </summary>
    public decimal Price { get; set; }
    /// <summary>
    /// 外键关联stocks表id字段
    /// </summary>
    public int StockId { get; set; }
}

// 业绩预告表
public class PerformanceForecasts
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 预告日期
    /// </summary>
    public DateTime ForecastDate { get; set; }
    /// <summary>
    /// 收益预测
    /// </summary>
    public decimal EarningsForecast { get; set; }
    /// <summary>
    /// 收入预测
    /// </summary>
    public decimal RevenueForecast { get; set; }
    /// <summary>
    /// 外键关联stocks表id字段
    /// </summary>
    public int StockId { get; set; }
}

// 股票评级表
public class StockRatings
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 评级日期
    /// </summary>
    public DateTime RatingDate { get; set; }
    /// <summary>
    /// 分析师
    /// </summary>
    public string Analyst { get; set; }
    /// <summary>
    /// 评级等级
    /// </summary>
    public string Rating { get; set; }
    /// <summary>
    /// 目标股价
    /// </summary>
    public decimal TargetPrice { get; set; }
    /// <summary>
    /// 外键关联stocks表id字段
    /// </summary>
    public int StockId { get; set; }
}

// 股票交易流通情况表
public class StockCirculation
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 流通日期
    /// </summary>
    public DateTime CirculationDate { get; set; }
    /// <summary>
    /// 流通股本
    /// </summary>
    public long CirculatingShares { get; set; }
    /// <summary>
    /// 换手率
    /// </summary>
    public decimal TurnoverRate { get; set; }
    /// <summary>
    /// 外键关联stocks表id字段
    /// </summary>
    public int StockId { get; set; }
}

// 股票市场行情表
public class MarketQuotes
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 报价日期
    /// </summary>
    public DateTime QuoteDate { get; set; }
    /// <summary>
    /// 最新价格
    /// </summary>
    public decimal LastPrice { get; set; }
    /// <summary>
    /// 买入价格
    /// </summary>
    public decimal BidPrice { get; set; }
    /// <summary>
    /// 卖出价格
    /// </summary>
    public decimal AskPrice { get; set; }
    /// <summary>
    /// 买入数量
    /// </summary>
    public long BidSize { get; set; }
    /// <summary>
    /// 卖出数量
    /// </summary>
    public long AskSize { get; set; }
    /// <summary>
    /// 外键关联stocks表id字段
    /// </summary>
    public int StockId { get; set; }
}

// 股票分析师报告表
public class AnalystReports
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 报告日期
    /// </summary>
    public DateTime ReportDate { get; set; }
    /// <summary>
    /// 分析师
    /// </summary>
    public string Analyst { get; set; }
    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// 内容
    /// </summary>
    public string Content { get; set; }
    /// <summary>
    /// 外键关联stocks表id字段
    /// </summary>
    public int StockId { get; set; }
}

// 股票交易费用表
public class TradingFees
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 交易日期
    /// </summary>
    public DateTime TradeDate { get; set; }
    /// <summary>
    /// 费用类型
    /// </summary>
    public string FeeType { get; set; }
    /// <summary>
    /// 费用金额
    /// </summary>
    public decimal FeeAmount { get; set; }
    /// <summary>
    /// 外键关联stocks表id字段
    /// </summary>
    public int StockId { get; set; }
}

// 股票持仓表
public class StockPositions
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 持仓日期
    /// </summary>
    public DateTime PositionDate { get; set; }
    /// <summary>
    /// 数量
    /// </summary>
    public long Quantity { get; set; }
    /// <summary>
    /// 成本
    /// </summary>
    public decimal CostBasis { get; set; }
    /// <summary>
    /// 外键关联stocks表id字段
    /// </summary>
    public int StockId { get; set; }
}

// 股票回购表
public class StockRepurchases
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 回购日期
    /// </summary>
    public DateTime RepurchaseDate { get; set; }
    /// <summary>
    /// 回购数量
    /// </summary>
    public long SharesRepurchased { get; set; }
    /// <summary>
    /// 回购价格
    /// </summary>
    public decimal PricePaid { get; set; }
    /// <summary>
    /// 外键关联stocks表id字段
    /// </summary>
    public int StockId { get; set; }
}

// 股票期权表
public class StockOptions
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 期权日期
    /// </summary>
    public DateTime OptionDate { get; set; }
    /// <summary>
    /// 期权类型
    /// </summary>
    public string OptionType { get; set; }
    /// <summary>
    /// 行权价
    /// </summary>
    public decimal StrikePrice { get; set; }
    /// <summary>
    /// 到期日期
    /// </summary>
    public DateTime ExpirationDate { get; set; }
    /// <summary>
    /// 外键关联stocks表id字段
    /// </summary>
    public int StockId { get; set; }
}

// 股票质押表
public class StockPledges
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 质押日期
    /// </summary>
    public DateTime PledgeDate { get; set; }
    /// <summary>
    /// 抵押人
    /// </summary>
    public string PledgeeName { get; set; }
    /// <summary>
    /// 抵押股数
    /// </summary>
    public long PledgedShares { get; set; }
    /// <summary>
    /// 抵押金额
    /// </summary>
    public decimal PledgeAmount { get; set; }
    /// <summary>
    /// 外键关联stocks表id字段
    /// </summary>
    public int StockId { get; set; }
}

// 股票交易结算表格
public class TradeSettlements
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 结算日期
    /// </summary>
    public DateTime SettlementDate { get; set; }
    /// <summary>
    /// 数量
    /// </summary>
    public long Quantity { get; set; }
    /// <summary>
    /// 成交价格
    /// </summary>
    public decimal Price { get; set; }
    /// <summary>
    /// 总金额
    /// </summary>
    public decimal TotalAmount { get; set; }
    /// <summary>
    /// 外键关联stocks表id字段
    /// </summary>
    public int StockId { get; set; }
}

// 股票市值表格
public class MarketCapitalizations
{
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 股票代码
    /// </summary>
    public string Symbol { get; set; }
    /// <summary>
    /// 股票名称
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// 市值
    /// </summary>
    public decimal MarketCap { get; set; }
    /// <summary>
    /// 收盘价
    /// </summary>
    public decimal ClosePrice { get; set; }
    /// <summary>
    /// 市值
    /// </summary>
    public decimal MarketValue { get; set; }
}

// 股票行情数据备份表
public class MarketDataBackup
{
    /// <summary>
    /// 主键id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 股票id
    /// </summary>
    public int StockId { get; set; }
    /// <summary>
    /// 价格日期
    /// </summary>
    public DateTime PriceDate { get; set; }
    /// <summary>
    /// 开盘价
    /// </summary>
    public decimal OpenPrice { get; set; }
    /// <summary>
    /// 最高价
    /// </summary>
    public decimal HighPrice { get; set; }
    /// <summary>
    /// 最低价
    /// </summary>
    public decimal LowPrice { get; set; }
    /// <summary>
    /// 收盘价
    /// </summary>
    public decimal ClosePrice { get; set; }
    /// <summary>
    /// 成交量
    /// </summary>
    public long Volume { get; set; }
    /// <summary>
    /// 外键关联stocks表id字段
    /// </summary>
    public int StockId { get; set; }
}

}
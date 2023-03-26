/// <summary>
/// 股票
/// </summary>
[Table("stocks")]
public class Stock : AggregateRoot<int>
{
    /// <summary>
    /// 名称
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 符号
    /// </summary>
    [Index(IsUnique = true)]
    [MaxLength(10)]
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
    public DateTime? ListedDate { get; set; }

    /// <summary>
    /// 是否活跃
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// 财务报表
    /// </summary>
    public virtual ICollection<FinancialStatement> FinancialStatements { get; set; }

    /// <summary>
    /// 股票公告
    /// </summary>
    public virtual ICollection<StockAnnouncement> StockAnnouncements { get; set; }

    /// <summary>
    /// 股票价格
    /// </summary>
    public virtual ICollection<StockPrice> StockPrices { get; set; }

    /// <summary>
    /// 财务数据
    /// </summary>
    public virtual ICollection<FinancialData> FinancialData { get; set; }

    /// <summary>
    /// K线数据
    /// </summary>
    public virtual ICollection<KLineData> KLineData { get; set; }

    /// <summary>
    /// 股票新闻
    /// </summary>
    public virtual ICollection<StockNews> StockNews { get; set; }

    /// <summary>
    /// 股息
    /// </summary>
    public virtual ICollection<Dividend> Dividends { get; set; }

    /// <summary>
    /// 股份变动
    /// </summary>
    public virtual ICollection<ShareChange> ShareChanges { get; set; }

    /// <summary>
    /// 股东持股
    /// </summary>
    public virtual ICollection<ShareholderHolding> ShareholderHoldings { get; set; }

    /// <summary>
    /// 董事会决议
    /// </summary>
    public virtual ICollection<BoardResolution> BoardResolutions { get; set; }

    /// <summary>
    /// 股票交易
    /// </summary>
    public virtual ICollection<StockTrade> StockTrades { get; set; }

    /// <summary>
    /// 绩效预测
    /// </summary>
    public virtual ICollection<PerformanceForecast> PerformanceForecasts { get; set; }

    /// <summary>
    /// 股票评级
    /// </summary>
    public virtual ICollection<StockRating> StockRatings { get; set; }

    /// <summary>
    /// 股票流通
    /// </summary>
    public virtual ICollection<StockCirculation> StockCirculations { get; set; }

    /// <summary>
    /// 市场行情
    /// </summary>
    public virtual ICollection<MarketQuote> MarketQuotes { get; set; }

    /// <summary>
    /// 分析师报告
    /// </summary>
    public virtual ICollection<AnalystReport> AnalystReports { get; set; }

    /// <summary>
    /// 交易费用
    /// </summary>
    public virtual ICollection<TradingFee> TradingFees { get; set; }

    /// <summary>
    /// 股票头寸
    /// </summary>
    public virtual ICollection<StockPosition> StockPositions { get; set; }

    /// <summary>
    /// 股票回购
    /// </summary>
    public virtual ICollection<StockRepurchase> StockRepurchases { get; set; }

    /// <summary>
    /// 股票期权
    /// </summary>
    public virtual ICollection<StockOption> StockOptions { get; set; }

    /// <summary>
    /// 股票质押
    /// </summary>
    public virtual ICollection<StockPledge> StockPledges { get; set; }

    /// <summary>
    /// 交易结算
    /// </summary>
    public virtual ICollection<TradeSettlement> TradeSettlements { get; set; }

    /// <summary>
    /// 市值
    /// </summary>
    public virtual ICollection<MarketCapitalization> MarketCapitalizations { get; set; }
    
    /// <summary>
    /// 股票高管
    /// </summary>
    public virtual ICollection<StockExecutive> StockExecutives { get; set; }
    
}

/// <summary>
/// 股票仓储库接口
/// </summary>
public interface IStockRepository : IRepository<Stock, int>
{
    // 财务报表
    /// <summary>
    /// 获取股票的财务报表
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<FinancialStatement>> GetFinancialStatementsAsync(int stockId);
    /// <summary>
    /// 添加股票的财务报表
    /// </summary>
    /// <param name="financialStatement">财务报表</param>
    Task AddFinancialStatementAsync(FinancialStatement financialStatement);
    /// <summary>
    /// 更新股票的财务报表
    /// </summary>
    /// <param name="financialStatement">财务报表</param>
    void UpdateFinancialStatement(FinancialStatement financialStatement);
    /// <summary>
    /// 删除股票的财务报表
    /// </summary>
    /// <param name="financialStatement">财务报表</param>
    void RemoveFinancialStatement(FinancialStatement financialStatement);

    // 股票公告
    /// <summary>
    /// 获取股票的公告
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<StockAnnouncement>> GetStockAnnouncementsAsync(int stockId);
    /// <summary>
    /// 添加股票的公告
    /// </summary>
    /// <param name="stockAnnouncement">公告</param>
    Task AddStockAnnouncementAsync(StockAnnouncement stockAnnouncement);
    /// <summary>
    /// 更新股票的公告
    /// </summary>
    /// <param name="stockAnnouncement">公告</param>
    void UpdateStockAnnouncement(StockAnnouncement stockAnnouncement);
    /// <summary>
    /// 删除股票的公告
    /// </summary>
    /// <param name="stockAnnouncement">公告</param>
    void RemoveStockAnnouncement(StockAnnouncement stockAnnouncement);

    // 股票价格
    /// <summary>
    /// 获取股票的价格
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<StockPrice>> GetStockPricesAsync(int stockId);
    /// <summary>
    /// 添加股票的价格
    /// </summary>
    /// <param name="stockPrice">价格</param>
    Task AddStockPriceAsync(StockPrice stockPrice);
    /// <summary>
    /// 更新股票的价格
    /// </summary>
    /// <param name="stockPrice">价格</param>
    void UpdateStockPrice(StockPrice stockPrice);
    /// <summary>
    /// 删除股票的价格
    /// </summary>
    /// <param name="stockPrice">价格</param>
    void RemoveStockPrice(StockPrice stockPrice);

    // 财务数据
    /// <summary>
    /// 获取股票的财务数据
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<FinancialData>> GetFinancialDataAsync(int stockId);
    /// <summary>
    /// 添加股票的财务数据
    /// </summary>
    /// <param name="financialData">财务数据</param>
    Task AddFinancialDataAsync(FinancialData financialData);
    /// <summary>
    /// 更新股票的财务数据
    /// </summary>
    /// <param name="financialData">财务数据</param>
    void UpdateFinancialData(FinancialData financialData);
    /// <summary>
    /// 删除股票的财务数据
    /// </summary>
    /// <param name="financialData">财务数据</param>
    void RemoveFinancialData(FinancialData financialData);

    // K线数据
    /// <summary>
    /// 获取股票的K线数据
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<KLineData>> GetKLineDataAsync(int stockId);
    /// <summary>
    /// 添加股票的K线数据
    /// </summary>
    /// <param name="kLineData">K线数据</param>
    Task AddKLineDataAsync(KLineData kLineData);
    /// <summary>
    /// 更新股票的K线数据
    /// </summary>
    /// <param name="kLineData">K线数据</param>
    void UpdateKLineData(KLineData kLineData);
    /// <summary>
    /// 删除股票的K线数据
    /// </summary>
    /// <param name="kLineData">K线数据</param>
    void RemoveKLineData(KLineData kLineData);

    // 股票新闻
    /// <summary>
    /// 获取股票的新闻
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<StockNews>> GetStockNewsAsync(int stockId);
    /// <summary>
    /// 添加股票的新闻
    /// </summary>
    /// <param name="stockNews">新闻</param>
    Task AddStockNewsAsync(StockNews stockNews);
    /// <summary>
    /// 更新股票的新闻
    /// </summary>
    /// <param name="stockNews">新闻</param>
    void UpdateStockNews(StockNews stockNews);
    /// <summary>
    /// 删除股票的新闻
    /// </summary>
    /// <param name="stockNews">新闻</param>
    void RemoveStockNews(StockNews stockNews);

    // 股息
    /// <summary>
    /// 获取股票的股息
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<Dividend>> GetDividendsAsync(int stockId);
    /// <summary>
    /// 添加股票的股息
    /// </summary>
    /// <param name="dividend">股息</param>
    Task AddDividendAsync(Dividend dividend);
    /// <summary>
    /// 更新股票的股息
    /// </summary>
    /// <param name="dividend">股息</param>
    void UpdateDividend(Dividend dividend);
    /// <summary>
    /// 删除股票的股息
    /// </summary>
    /// <param name="dividend">股息</param>
    void RemoveDividend(Dividend dividend);

    // 股份变动
    /// <summary>
    /// 获取股票的股份变动
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<ShareChange>> GetShareChangesAsync(int stockId);
    /// <summary>
    /// 添加股票的股份变动
    /// </summary>
    /// <param name="shareChange">股份变动</param>
    Task AddShareChangeAsync(ShareChange shareChange);
    /// <summary>
    /// 更新股票的股份变动
    /// </summary>
    /// <param name="shareChange">股份变动</param>
    void UpdateShareChange(ShareChange shareChange);
    /// <summary>
    /// 删除股票的股份变动
    /// </summary>
    /// <param name="shareChange">股份变动</param>
    void RemoveShareChange(ShareChange shareChange);

    // 股东持股
    /// <summary>
    /// 获取股票的股东持股
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<ShareholderHolding>> GetShareholderHoldingsAsync(int stockId);
    /// <summary>
    /// 添加股票的股东持股
    /// </summary>
    /// <param name="shareholderHolding">股东持股</param>
    Task AddShareholderHoldingAsync(ShareholderHolding shareholderHolding);
    /// <summary>
    /// 更新股票的股东持股
    /// </summary>
    /// <param name="shareholderHolding">股东持股</param>
    void UpdateShareholderHolding(ShareholderHolding shareholderHolding);
    /// <summary>
    /// 删除股票的股东持股
    /// </summary>
    /// <param name="shareholderHolding">股东持股</param>
    void RemoveShareholderHolding(ShareholderHolding shareholderHolding);

    // 董事会决议
    /// <summary>
    /// 获取股票的董事会决议
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<BoardResolution>> GetBoardResolutionsAsync(int stockId);
    /// <summary>
    /// 添加股票的董事会决议
    /// </summary>
    /// <param name="boardResolution">董事会决议</param>
    Task AddBoardResolutionAsync(BoardResolution boardResolution);
    /// <summary>
    /// 更新股票的董事会决议
    /// </summary>
    /// <param name="boardResolution">董事会决议</param>
    void UpdateBoardResolution(BoardResolution boardResolution);
    /// <summary>
    /// 删除股票的董事会决议
    /// </summary>
    /// <param name="boardResolution">董事会决议</param>
    void RemoveBoardResolution(BoardResolution boardResolution);

    // 股票交易
    /// <summary>
    /// 获取股票的交易
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<StockTrade>> GetStockTradesAsync(int stockId);
    /// <summary>
    /// 添加股票的交易
    /// </summary>
    /// <param name="stockTrade">交易</param>
    Task AddStockTradeAsync(StockTrade stockTrade);
    /// <summary>
    /// 更新股票的交易
    /// </summary>
    /// <param name="stockTrade">交易</param>
    void UpdateStockTrade(StockTrade stockTrade);
    /// <summary>
    /// 删除股票的交易
    /// </summary>
    /// <param name="stockTrade">交易</param>
    void RemoveStockTrade(StockTrade stockTrade);

    // 绩效预测
    /// <summary>
    /// 获取股票的绩效预测
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<PerformanceForecast>> GetPerformanceForecastsAsync(int stockId);
    /// <summary>
    /// 添加股票的绩效预测
    /// </summary>
    /// <param name="performanceForecast">绩效预测</param>
    Task AddPerformanceForecastAsync(PerformanceForecast performanceForecast);
    /// <summary>
    /// 更新股票的绩效预测
    /// </summary>
    /// <param name="performanceForecast">绩效预测</param>
    void UpdatePerformanceForecast(PerformanceForecast performanceForecast);
    /// <summary>
    /// 删除股票的绩效预测
    /// </summary>
    /// <param name="performanceForecast">绩效预测</param>
    void RemovePerformanceForecast(PerformanceForecast performanceForecast);

    // 股票评级
    /// <summary>
    /// 获取股票的评级
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<StockRating>> GetStockRatingsAsync(int stockId);
    /// <summary>
    /// 添加股票的评级
    /// </summary>
    /// <param name="stockRating">评级</param>
    Task AddStockRatingAsync(StockRating stockRating);
    /// <summary>
    /// 更新股票的评级
    /// </summary>
    /// <param name="stockRating">评级</param>
    void UpdateStockRating(StockRating stockRating);
    /// <summary>
    /// 删除股票的评级
    /// </summary>
    /// <param name="stockRating">评级</param>
    void RemoveStockRating(StockRating stockRating);

    // 股票流通
    /// <summary>
    /// 获取股票的流通
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<StockCirculation>> GetStockCirculationsAsync(int stockId);
    /// <summary>
    /// 添加股票的流通
    /// </summary>
    /// <param name="stockCirculation">流通</param>
    Task AddStockCirculationAsync(StockCirculation stockCirculation);
    /// <summary>
    /// 更新股票的流通
    /// </summary>
    /// <param name="stockCirculation">流通</param>
    void UpdateStockCirculation(StockCirculation stockCirculation);
    /// <summary>
    /// 删除股票的流通
    /// </summary>
    /// <param name="stockCirculation">流通</param>
    void RemoveStockCirculation(StockCirculation stockCirculation);

    // 市场行情
    /// <summary>
    /// 获取股票的市场行情
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<MarketQuote>> GetMarketQuotesAsync(int stockId);
    /// <summary>
    /// 添加股票的市场行情
    /// </summary>
    /// <param name="marketQuote">市场行情</param>
    Task AddMarketQuoteAsync(MarketQuote marketQuote);
    /// <summary>
    /// 更新股票的市场行情
    /// </summary>
    /// <param name="marketQuote">市场行情</param>
    void UpdateMarketQuote(MarketQuote marketQuote);
    /// <summary>
    /// 删除股票的市场行情
    /// </summary>
    /// <param name="marketQuote">市场行情</param>
    void RemoveMarketQuote(MarketQuote marketQuote);

    // 分析师报告
    /// <summary>
    /// 获取股票的分析师报告
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<AnalystReport>> GetAnalystReportsAsync(int stockId);
    /// <summary>
    /// 添加股票的分析师报告
    /// </summary>
    /// <param name="analystReport">分析师报告</param>
    Task AddAnalystReportAsync(AnalystReport analystReport);
    /// <summary>
    /// 更新股票的分析师报告
    /// </summary>
    /// <param name="analystReport">分析师报告</param>
    void UpdateAnalystReport(AnalystReport analystReport);
    /// <summary>
    /// 删除股票的分析师报告
    /// </summary>
    /// <param name="analystReport">分析师报告</param>
    void RemoveAnalystReport(AnalystReport analystReport);

    // 交易费用
    /// <summary>
    /// 获取股票的交易费用
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<TradingFee>> GetTradingFeesAsync(int stockId);
    /// <summary>
    /// 添加股票的交易费用
    /// </summary>
    /// <param name="tradingFee">交易费用</param>
    Task AddTradingFeeAsync(TradingFee tradingFee);
    /// <summary>
    /// 更新股票的交易费用
    /// </summary>
    /// <param name="tradingFee">交易费用</param>
    void UpdateTradingFee(TradingFee tradingFee);
    /// <summary>
    /// 删除股票的交易费用
    /// </summary>
    /// <param name="tradingFee">交易费用</param>
    void RemoveTradingFee(TradingFee tradingFee);

    // 股票头寸
    /// <summary>
    /// 获取股票的头寸
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<StockPosition>> GetStockPositionsAsync(int stockId);
    /// <summary>
    /// 添加股票的头寸
    /// </summary>
    /// <param name="stockPosition">头寸</param>
    Task AddStockPositionAsync(StockPosition stockPosition);
    /// <summary>
    /// 更新股票的头寸
    /// </summary>
    /// <param name="stockPosition">头寸</param>
    void UpdateStockPosition(StockPosition stockPosition);
    /// <summary>
    /// 删除股票的头寸
    /// </summary>
    /// <param name="stockPosition">头寸</param>
    void RemoveStockPosition(StockPosition stockPosition);

    // 股票回购
    /// <summary>
    /// 获取股票的回购
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<StockRepurchase>> GetStockRepurchasesAsync(int stockId);
    /// <summary>
    /// 添加股票的回购
    /// </summary>
    /// <param name="stockRepurchase">回购</param>
    Task AddStockRepurchaseAsync(StockRepurchase stockRepurchase);
    /// <summary>
    /// 更新股票的回购
    /// </summary>
    /// <param name="stockRepurchase">回购</param>
    void UpdateStockRepurchase(StockRepurchase stockRepurchase);
    /// <summary>
    /// 删除股票的回购
    /// </summary>
    /// <param name="stockRepurchase">回购</param>
    void RemoveStockRepurchase(StockRepurchase stockRepurchase);

    // 股票期权
    /// <summary>
    /// 获取股票的期权
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<StockOption>> GetStockOptionsAsync(int stockId);
    /// <summary>
    /// 添加股票的期权
    /// </summary>
    /// <param name="stockOption">期权</param>
    Task AddStockOptionAsync(StockOption stockOption);
    /// <summary>
    /// 更新股票的期权
    /// </summary>
    /// <param name="stockOption">期权</param>
    void UpdateStockOption(StockOption stockOption);
    /// <summary>
    /// 删除股票的期权
    /// </summary>
    /// <param name="stockOption">期权</param>
    void RemoveStockOption(StockOption stockOption);

    // 股票质押
    /// <summary>
    /// 获取股票的质押
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<StockPledge>> GetStockPledgesAsync(int stockId);
    /// <summary>
    /// 添加股票的质押
    /// </summary>
    /// <param name="stockPledge">质押</param>
    Task AddStockPledgeAsync(StockPledge stockPledge);
    /// <summary>
    /// 更新股票的质押
    /// </summary>
    /// <param name="stockPledge">质押</param>
    void UpdateStockPledge(StockPledge stockPledge);
    /// <summary>
    /// 删除股票的质押
    /// </summary>
    /// <param name="stockPledge">质押</param>
    void RemoveStockPledge(StockPledge stockPledge);

    // 交易结算
    /// <summary>
    /// 获取股票的交易结算
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<TradeSettlement>> GetTradeSettlementsAsync(int stockId);
    /// <summary>
    /// 添加股票的交易结算
    /// </summary>
    /// <param name="tradeSettlement">交易结算</param>
    Task AddTradeSettlementAsync(TradeSettlement tradeSettlement);
    /// <summary>
    /// 更新股票的交易结算
    /// </summary>
    /// <param name="tradeSettlement">交易结算</param>
    void UpdateTradeSettlement(TradeSettlement tradeSettlement);
    /// <summary>
    /// 删除股票的交易结算
    /// </summary>
    /// <param name="tradeSettlement">交易结算</param>
    void RemoveTradeSettlement(TradeSettlement tradeSettlement);

    // 市值
    /// <summary>
    /// 获取股票的市值
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<MarketCapitalization>> GetMarketCapitalizationsAsync(int stockId);
    /// <summary>
    /// 添加股票的市值
    /// </summary>
    /// <param name="marketCapitalization">市值</param>
    Task AddMarketCapitalizationAsync(MarketCapitalization marketCapitalization);
    /// <summary>
    /// 更新股票的市值
    /// </summary>
    /// <param name="marketCapitalization">市值</param>
    void UpdateMarketCapitalization(MarketCapitalization marketCapitalization);
    /// <summary>
    /// 删除股票的市值
    /// </summary>
    /// <param name="marketCapitalization">市值</param>
    void RemoveMarketCapitalization(MarketCapitalization marketCapitalization);

    // 股票高管任期
    /// <summary>
    /// 获取股票高管任期
    /// </summary>
    /// <param name="stockId">股票ID</param>
    Task<List<StockExecutive>> GetStockExecutivesAsync(int stockId);
    /// <summary>
    /// 添加股票高管任期
    /// </summary>
    /// <param name="stockExecutive">高管</param>
    Task AddStockExecutiveAsync(StockExecutive stockExecutive);
    /// <summary>
    /// 更新股票高管任期
    /// </summary>
    /// <param name="stockExecutive">高管</param>
    void UpdateStockExecutive(StockExecutive stockExecutive);
    /// <summary>
    /// 删除股票高管任期
    /// </summary>
    /// <param name="stockExecutive">高管</param>
    void RemoveStockExecutive(StockExecutive stockExecutive);
    
}



/// <summary>
/// 财务报表
/// </summary>
[Table("financial_statements")]
public class FinancialStatement : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
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
    /// 总权益
    /// </summary>
    public decimal TotalEquity { get; set; }

    /// <summary>
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

/// <summary>
/// 股票公告
/// </summary>
[Table("stock_announcements")]
public class StockAnnouncement : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
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
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

/// <summary>
/// 股票价格
/// </summary>
[Table("stock_prices")]
public class StockPrice : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
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
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

/// <summary>
/// 财务数据
/// </summary>
[Table("financial_data")]
public class FinancialData : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
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
    /// 总权益
    /// </summary>
    public decimal TotalEquity { get; set; }

    /// <summary>
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

/// <summary>
/// K线数据
/// </summary>
[Table("k_line_data")]
public class KLineData : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
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
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

/// <summary>
/// 股票新闻
/// </summary>
[Table("stock_news")]
public class StockNews : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
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
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

/// <summary>
/// 股息
/// </summary>
[Table("dividends")]
public class Dividend : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
    public int StockId { get; set; }

    /// <summary>
    /// 除息日
    /// </summary>
    public DateTime ExDividendDate { get; set; }

    /// <summary>
    /// 股息金额
    /// </summary>
    public decimal DividendAmount { get; set; }

    /// <summary>
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

/// <summary>
/// 股份变动
/// </summary>
[Table("share_changes")]
public class ShareChange : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
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
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

/// <summary>
/// 股东持股
/// </summary>
[Table("shareholder_holdings")]
public class ShareholderHolding : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
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
    /// 持股数
    /// </summary>
    public long SharesOwned { get; set; }

    /// <summary>
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

/// <summary>
/// 董事会决议
/// </summary>
[Table("board_resolutions")]
public class BoardResolution : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
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
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

/// <summary>
/// 股票交易
/// </summary>
[Table("stock_trades")]
public class StockTrade : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
    public int StockId { get; set; }

    /// <summary>
    /// 交易日期
    /// </summary>
    public DateTime TradeDate { get; set; }

    /// <summary>
    /// 买卖标志
    /// </summary>
    public char BuySellIndicator { get; set; }

    /// <summary>
    /// 数量
    /// </summary>
    public long Quantity { get; set; }

    /// <summary>
    /// 价格
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

/// <summary>
/// 绩效预测
/// </summary>
[Table("performance_forecasts")]
public class PerformanceForecast : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
    public int StockId { get; set; }

    /// <summary>
    /// 预测日期
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
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

/// <summary>
/// 股票评级
/// </summary>
[Table("stock_ratings")]
public class StockRating : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
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
    /// 评级
    /// </summary>
    public string Rating { get; set; }

    /// <summary>
    /// 目标价
    /// </summary>
    public decimal TargetPrice { get; set; }

    /// <summary>
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

/// <summary>
/// 股票流通
/// </summary>
[Table("stock_circulation")]
public class StockCirculation : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
    public int StockId { get; set; }

    /// <summary>
    /// 流通日期
    /// </summary>
    public DateTime CirculationDate { get; set; }

    /// <summary>
    /// 流通股数
    /// </summary>
    public long CirculatingShares { get; set; }

    /// <summary>
    /// 换手率
    /// </summary>
    public decimal TurnoverRate { get; set; }

    /// <summary>
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

/// <summary>
/// 市场行情
/// </summary>
[Table("market_quotes")]
public class MarketQuote : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
    public int StockId { get; set; }

    /// <summary>
    /// 报价日期
    /// </summary>
    public DateTime QuoteDate { get; set; }

    /// <summary>
    /// 最新价
    /// </summary>
    public decimal LastPrice { get; set; }

    /// <summary>
    /// 买价
    /// </summary>
    public decimal BidPrice { get; set; }

    /// <summary>
    /// 卖价
    /// </summary>
    public decimal AskPrice { get; set; }

    /// <summary>
    /// 买量
    /// </summary>
    public long BidSize { get; set; }

    /// <summary>
    /// 卖量
    /// </summary>
    public long AskSize { get; set; }

    /// <summary>
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

/// <summary>
/// 分析师报告
/// </summary>
[Table("analyst_reports")]
public class AnalystReport : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
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
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

/// <summary>
/// 交易费用
/// </summary>
[Table("trading_fees")]
public class TradingFee : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
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
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

/// <summary>
/// 股票头寸
/// </summary>
[Table("stock_positions")]
public class StockPosition : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
    public int StockId { get; set; }

    /// <summary>
    /// 头寸日期
    /// </summary>
    public DateTime PositionDate { get; set; }

    /// <summary>
    /// 数量
    /// </summary>
    public long Quantity { get; set; }

    /// <summary>
    /// 成本基础
    /// </summary>
    public decimal CostBasis { get; set; }

    /// <summary>
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

/// <summary>
/// 股票回购
/// </summary>
[Table("stock_repurchases")]
public class StockRepurchase : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
    public int StockId { get; set; }

    /// <summary>
    /// 回购日期
    /// </summary>
    public DateTime RepurchaseDate { get; set; }

    /// <summary>
    /// 回购股数
    /// </summary>
    public long SharesRepurchased { get; set; }

    /// <summary>
    /// 价格
    /// </summary>
    public decimal PricePaid { get; set; }

    /// <summary>
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

/// <summary>
/// 股票期权
/// </summary>
[Table("stock_options")]
public class StockOption : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
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
    /// 行权价格
    /// </summary>
    public decimal StrikePrice { get; set; }

    /// <summary>
    /// 到期日期
    /// </summary>
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

/// <summary>
/// 股票质押
/// </summary>
[Table("stock_pledges")]
public class StockPledge : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
    public int StockId { get; set; }

    /// <summary>
    /// 质押日期
    /// </summary>
    public DateTime PledgeDate { get; set; }

    /// <summary>
    /// 质押人名称
    /// </summary>
    public string PledgeeName { get; set; }

    /// <summary>
    /// 质押股数
    /// </summary>
    public long PledgedShares { get; set; }

    /// <summary>
    /// 质押金额
    /// </summary>
    public decimal PledgeAmount { get; set; }

    /// <summary>
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

/// <summary>
/// 交易结算
/// </summary>
[Table("trade_settlements")]
public class TradeSettlement : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
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
    /// 价格
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// 总金额
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

/// <summary>
/// 市值
/// </summary>
[Table("market_capitalizations")]
public class MarketCapitalization : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
    public int StockId { get; set; }

    /// <summary>
    /// 代码
    /// </summary>
    public string Symbol { get; set; }

    /// <summary>
    /// 名称
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

    /// <summary>
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

/// <summary>
/// 股票高管任期
/// </summary>
[Table("stock_executives")]
public class StockExecutive : Entity<int>
{
    /// <summary>
    /// 股票ID
    /// </summary>
    [ForeignKey("Stock")]
    public int StockId { get; set; }

    /// <summary>
    /// 高管姓名
    /// </summary>
    public string ExecutiveName { get; set; }

    /// <summary>
    /// 任期开始日期
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// 任期结束日期
    /// </summary>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// 股票
    /// </summary>
    public virtual Stock Stock { get; set; }
}

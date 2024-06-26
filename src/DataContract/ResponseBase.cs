﻿using MaxiPago.DataContract.NonTransactional;
using MaxiPago.DataContract.Reports;
using MaxiPago.DataContract.Transactional;

namespace MaxiPago.DataContract;

public abstract class ResponseBase {

    public bool IsTransactionResponse {
        get { return this is TransactionResponse; }
    }

    public bool IsErrorResponse {
        get { return this is ErrorResponse; }
    }

    public bool IsApiResponse {
        get { return this is ApiResponse; }
    }

    public bool IsReportResponse {
        get { return this is RapiResponse; }
    }

}

# coding: utf-8

"""
LiquidationApi.py
Copyright 2015 SmartBear Software

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
"""

from __future__ import absolute_import

import sys
import os

# python 2 and python 3 compatibility library
from six import iteritems

from ..configuration import Configuration
from ..api_client import ApiClient


class LiquidationApi(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    Ref: https://github.com/swagger-api/swagger-codegen
    """

    def __init__(self, api_client=None):
        config = Configuration()
        if api_client:
            self.api_client = api_client
        else:
            if not config.api_client:
                config.api_client = ApiClient()
            self.api_client = config.api_client

    def liquidation_get(self, **kwargs):
        """
        Get liquidation orders.
        

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.liquidation_get(callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param str symbol: Instrument symbol. Send a bare series (e.g. XBU) to get data for the nearest expiring contract in that series.\n\nYou can also send a timeframe, e.g. `XBU:monthly`. Timeframes are `daily`, `weekly`, `monthly`, `quarterly`, and `biquarterly`.
        :param str filter: Generic table filter. Send JSON key/value pairs, such as `{\"key\": \"value\"}`. You can key on individual fields, and do more advanced querying on timestamps. See the [Timestamp Docs](https://www.bitmex.com/app/restAPI#timestamp-filters) for more details.
        :param str columns: Array of column names to fetch. If omitted, will return all columns.\n\nNote that this method will always return item keys, even when not specified, so you may receive more columns that you expect.
        :param float count: Number of results to fetch.
        :param float start: Starting point for results.
        :param bool reverse: If true, will sort results newest first.
        :param date start_time: Starting date filter for results.
        :param date end_time: Ending date filter for results.
        :return: list[Liquidation]
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['symbol', 'filter', 'columns', 'count', 'start', 'reverse', 'start_time', 'end_time']
        all_params.append('callback')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method liquidation_get" % key
                )
            params[key] = val
        del params['kwargs']


        resource_path = '/liquidation'.replace('{format}', 'json')
        method = 'GET'

        path_params = {}

        query_params = {}
        if 'symbol' in params:
            query_params['symbol'] = params['symbol']
        if 'filter' in params:
            query_params['filter'] = params['filter']
        if 'columns' in params:
            query_params['columns'] = params['columns']
        if 'count' in params:
            query_params['count'] = params['count']
        if 'start' in params:
            query_params['start'] = params['start']
        if 'reverse' in params:
            query_params['reverse'] = params['reverse']
        if 'start_time' in params:
            query_params['startTime'] = params['start_time']
        if 'end_time' in params:
            query_params['endTime'] = params['end_time']

        header_params = {}

        form_params = {}
        files = {}

        body_params = None

        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json', 'application/xml', 'text/xml', 'application/javascript', 'text/javascript'])
        if not header_params['Accept']:
            del header_params['Accept']

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.\
            select_header_content_type(['application/json', 'application/x-www-form-urlencoded'])

        # Authentication setting
        auth_settings = []

        response = self.api_client.call_api(resource_path, method,
                                            path_params,
                                            query_params,
                                            header_params,
                                            body=body_params,
                                            post_params=form_params,
                                            files=files,
                                            response_type='list[Liquidation]',
                                            auth_settings=auth_settings,
                                            callback=params.get('callback'))
        return response

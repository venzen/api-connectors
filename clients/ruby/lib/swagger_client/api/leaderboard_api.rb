=begin
#BitMEX API

#REST API for the BitMEX.com trading platform.<br><br><a href=\"/app/restAPI\">REST Documentation</a><br><a href=\"/app/wsAPI\">Websocket Documentation</a>

OpenAPI spec version: 1.2.0
Contact: support@bitmex.com
Generated by: https://github.com/swagger-api/swagger-codegen.git

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

=end

require "uri"

module SwaggerClient
  class LeaderboardApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end

    # Get current leaderboard.
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :method Ranking type. Options: \&quot;notional\&quot;, \&quot;ROE\&quot; (default to notional)
    # @return [Array<Leaderboard>]
    def leaderboard_get(opts = {})
      data, _status_code, _headers = leaderboard_get_with_http_info(opts)
      return data
    end

    # Get current leaderboard.
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :method Ranking type. Options: \&quot;notional\&quot;, \&quot;ROE\&quot;
    # @return [Array<(Array<Leaderboard>, Fixnum, Hash)>] Array<Leaderboard> data, response status code and response headers
    def leaderboard_get_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: LeaderboardApi.leaderboard_get ..."
      end
      # resource path
      local_var_path = "/leaderboard".sub('{format}','json')

      # query parameters
      query_params = {}
      query_params[:'method'] = opts[:'method'] if !opts[:'method'].nil?

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      local_header_accept = ['application/json', 'application/xml', 'text/xml', 'application/javascript', 'text/javascript']
      local_header_accept_result = @api_client.select_header_accept(local_header_accept) and header_params['Accept'] = local_header_accept_result

      # HTTP header 'Content-Type'
      local_header_content_type = ['application/json', 'application/x-www-form-urlencoded']
      header_params['Content-Type'] = @api_client.select_header_content_type(local_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      auth_names = []
      data, status_code, headers = @api_client.call_api(:GET, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Array<Leaderboard>')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: LeaderboardApi#leaderboard_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end

import axios from "axios"
import * as asyncStorage from "../store/asyncStorage"

const request = axios.create({
  baseURL: "https://y3s2-uitevent.azurewebsites.net/api/",
})

export const getMethod = async (
  path,
  hasAuth = false,
  params = {},
  options = {}
) => {
  const headers = {
    Authorization: "Bearer " + (await asyncStorage.getAccessToken()),
  }

  if (hasAuth) {
    options.headers = headers
  }

  options.params = params || {}
  const response = await request.get(path, options)

  return response.data
}

export const postMethod = async (path, hasAuth = false, options = {}) => {
  let headers = {}

  if (hasAuth) {
    headers = {
      Authorization: "Bearer " + (await asyncStorage.getAccessToken()),
    }
  }
  console.log(path, options)

  const response = await request.post(path, options, {
    headers: headers,
  })
  return response.data
}

export const putMethod = async (path, options = {}) => {
  const headers = {
    accessToken: await asyncStorage.getAccessToken(),
  }

  const response = await request.put(path, options, {
    headers: headers,
  })
  return response.data
}

export const deleteMethod = async (path) => {
  const headers = {
    accessToken: await asyncStorage.getAccessToken(),
  }

  const response = await request.delete(path, {
    headers: headers,
  })
  return response.data
}

export default request

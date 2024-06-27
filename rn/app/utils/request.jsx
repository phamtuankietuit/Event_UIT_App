import axios from "axios"
import * as asyncStorage from "../store/asyncStorage"

const request = axios.create({
  baseURL: "https://y3s2-uitevent.azurewebsites.net/api/",
})

export const getMethod = async (
  path,
  hasAuth = false,
  isUnit = false,
  params = {},
  options = {}
) => {
  const headersStudent = {
    Authorization:
      "Bearer " + JSON.stringify(asyncStorage.getStudentAccessToken()),
  }

  const headersUnit = {
    Authorization:
      "Bearer " + JSON.stringify(asyncStorage.getUnitAccessToken()),
  }

  if (hasAuth) {
    options.headers = isUnit ? headersUnit : headersStudent
  }

  options.params = params || {}

  const response = await request.get(path, options)

  return response.data
}

export const postMethod = async (
  path,
  hasAuth = false,
  isUnit = false,
  options = {}
) => {
  let headers = {}

  if (hasAuth) {
    headers = {
      Authorization:
        "Bearer " +
        (isUnit
          ? JSON.stringify(asyncStorage.getUnitAccessToken())
          : JSON.stringify(asyncStorage.getStudentAccessToken())),
    }
  }

  const response = await request.post(path, options, {
    headers: headers,
  })

  return response.data
}

export const putMethod = async (path, isUnit = false, options = {}) => {
  const headersStudent = {
    accessToken: asyncStorage.getStudentAccessToken(),
  }

  const headersUnit = {
    accessToken: asyncStorage.getUnitAccessToken(),
  }

  const response = await request.put(path, options, {
    headers: isUnit ? headersUnit : headersStudent,
  })
  return response.data
}

export const deleteMethod = async (path, isUnit = false) => {
  const headersStudent = {
    accessToken: asyncStorage.getStudentAccessToken(),
  }

  const headersUnit = {
    accessToken: asyncStorage.getUnitAccessToken(),
  }

  const response = await request.delete(path, {
    headers: isUnit ? headersUnit : headersStudent,
  })
  return response.data
}

export default request

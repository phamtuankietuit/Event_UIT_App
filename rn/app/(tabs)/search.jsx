import React, { useEffect, useState, useCallback } from "react"
import { FlatList, Text, TouchableOpacity, View, RefreshControl } from "react-native"
import SearchBar from "../components/SearchBar"
import * as PageServices from "../apiServices/pageServices"
import * as EventServices from "../apiServices/eventServices"
import Page_Item from '../components/Page_Item';
import EventItem from "../components/EventItem";

const Search = () => {
  const [value, setValue] = useState("")
  const [listPage, setListPage] = useState([])
  const [listEvent, setListEvent] = useState([])
  const [refreshing, setRefreshing] = useState(false)
  const [stage, setStage] = useState(true)

  const onRefresh = useCallback(() => {
    setRefreshing(true)

  }, [])
  const search = () => {
    const fetchApi = async () => {
      setRefreshing(true)
      const responseEvent = await EventServices
        .getEvents({
          isPublished: true,
          SearchTerm: value
        })
        .catch((error) => {
          // xử lý lỗi
          if (error.response) {
            if (error.response.status === 401) {
              showToastWithGravity("Vui lòng kiểm tra lại email hoặc mật khẩu")
            } else if (error.response.status === 403) {
              showToastWithGravity("Tài khoản đã bị vô hiệu hóa")
            }
          } else {
            showToastWithGravity("Có lỗi xảy ra")
          }
        })

      if (responseEvent) {
        // Xử lý nếu response trả về
        // console.log(responseEvent.events.items)
        setListEvent(responseEvent.events.items)
      }
    }
    fetchApi()
    setRefreshing(false)
  }

  useEffect(() => {
    const fetchApi = async () => {
      const response = await PageServices
        .getPages()
        .catch((error) => {
          // xử lý lỗi
          if (error.response) {
            if (error.response.status === 401) {
              showToastWithGravity("Vui lòng kiểm tra lại email hoặc mật khẩu")
            } else if (error.response.status === 403) {
              showToastWithGravity("Tài khoản đã bị vô hiệu hóa")
            }
          } else {
            showToastWithGravity("Có lỗi xảy ra")
          }
        })

      if (response) {
        // Xử lý nếu response trả về
        // console.log(response)
        setListPage(response.items)

      }

      const responseEvent = await EventServices
        .getEvents({
          isPublished: true
        })
        .catch((error) => {
          // xử lý lỗi
          if (error.response) {
            if (error.response.status === 401) {
              showToastWithGravity("Vui lòng kiểm tra lại email hoặc mật khẩu")
            } else if (error.response.status === 403) {
              showToastWithGravity("Tài khoản đã bị vô hiệu hóa")
            }
          } else {
            showToastWithGravity("Có lỗi xảy ra")
          }
        })

      if (responseEvent) {
        // Xử lý nếu response trả về
        // console.log(responseEvent.events.items)
        setListEvent(responseEvent.events.items)
      }
    }
    fetchApi()
  }, [])

  const setLikePa = async (id, value) => {

  }
  return (
    <View className='flex-1 mt-2'>
      <View className='mx-4 my-2'>
        <SearchBar
          value={value}
          handleChange={setValue}
          placeholder='Tìm kiếm bài viết hoặc trang'
          search={search}
        />
      </View>

      <View className='mt-4'>
        <View className='mx-5 my-3 flex flex-row items-center rounded-3xl bg-white 
        p-1 shadow-sm shadow-black transition-all'>
          <TouchableOpacity
            className={stage === true ? 'w-[50%] bg-blue-600 p-2 rounded-full' : 'w-[50%] p-2 rounded-full'}
            onPress={() => setStage(true)}
          >
            <Text className={stage === true ? 'text-white text-center text-sm font-medium`' : 'text-center text-sm font-medium`'}>Bài viết</Text>
          </TouchableOpacity>
          <TouchableOpacity
            className={stage === false ? 'w-[50%] bg-blue-600 p-2 rounded-full' : 'w-[50%] p-2 rounded-full'}
            onPress={() => setStage(false)}
          >

            <Text className={stage === false ? 'text-white text-center text-sm font-medium`' : 'text-center text-sm font-medium`'}>Trang</Text>
          </TouchableOpacity>
        </View>
        {
          stage === true ? (
            <FlatList
              data={listEvent}
              showsVerticalScrollIndicator={false}
              className='mx-2 bg-transparent'
              keyExtractor={(item) => item.id}
              renderItem={({ item }) => <EventItem item={item} />}
              refreshControl={
                <RefreshControl
                  refreshing={refreshing}
                  onRefresh={onRefresh}
                  colors={["#3A57E8"]}
                  tintColor='#3A57E8'
                  progressViewOffset={20}
                />
              }
            />
          ) : (
            <FlatList
              data={listPage}
              showsVerticalScrollIndicator={false}
              className='mx-2 bg-transparent'
              keyExtractor={(item) => item.id}
              renderItem={({ item }) => <Page_Item item={item} setLike={setLikePa} />}
            />
          )
        }
      </View>
    </View>
  )
}

export default Search
